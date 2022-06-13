using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Z.Dapper.Plus;
using System.Data.SqlClient;
using System.IO;


namespace WindowsFormsApp2
{
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		private void Form7_Load(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
			//dataGridView1.DataSource = dt;
			if (dt != null)
			{
				List<Musteriimp> customers = new List<Musteriimp>();
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					Musteriimp Musteri = new Musteriimp();
					Musteri.musteri_id = dt.Rows[i]["musteri_id"].ToString();
					Musteri.musteri_ad = dt.Rows[i]["musteri_ad"].ToString();
					Musteri.musteri_soyad = dt.Rows[i]["musteri_soyad"].ToString();
					Musteri.musteri_tel = dt.Rows[i]["musteri_tel"].ToString();
					Musteri.musteri_eposta = dt.Rows[i]["musteri_eposta"].ToString();
					Musteri.musteri_adres = dt.Rows[i]["musteri_adres"].ToString();

					customers.Add(Musteri);

				}
				//customerBindingSource.DataSource = customers;
				musteriBindingSource.DataSource = customers;

			}
		}
		DataTableCollection tableCollection;

		//public object customerBindingSource { get; private set; }

		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 workbook|*.xls|Excel Workbook|*.xlsx" })
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					textBox1.Text = openFileDialog.FileName;
					using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
					{
						using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
						{
							DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
							{
								ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }

							});
							tableCollection = result.Tables;
							comboBox1.Items.Clear();
							foreach (DataTable table in tableCollection)
								comboBox1.Items.Add(table.TableName);  //sayfaları comboboxa ekler
						}
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "Server = KÜBRA\\SQLEXPRESS;Database=Proje;User Id =Admin; Password=8181;"; //sıkıntılı yer sadece burası, burası kaldı sadece!
				DapperPlusManager.Entity<Musteriimp>().Table("Customers");
				List<Musteriimp> customers = musteriBindingSource.DataSource as List<Musteriimp>;
				if (customers != null)
				{
					using (IDbConnection db = new SqlConnection(connectionString))
					{
						db.BulkInsert(customers);
					}
				}
				MessageBox.Show("Finish");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form7_Load_1(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'projeDataSet6.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.musteriTableAdapter.Fill(this.projeDataSet6.Musteri);

		}
	}
}
