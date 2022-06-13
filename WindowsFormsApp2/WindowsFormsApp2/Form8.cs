using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
	public partial class Form8 : Form
	{
		public Form8()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
		DataSet6TableAdapters.KullanicilarTableAdapter a = new DataSet6TableAdapters.KullanicilarTableAdapter();

		DataTable tablo = new DataTable();
		private void listele()
		{
			connection.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("Select * from Kullanicilar", connection);
			adtr.Fill(tablo);
			dataGridView2.DataSource = tablo;
			connection.Close();
		}

		private void sil_Click(object sender, EventArgs e)
		{
			connection.Open();
			a.Sil(textBox5.Text);

			
			connection.Close();
			MessageBox.Show("Kayıt Silindi", "Kayıt");
			textBox5.Clear();
			
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void Form8_Load(object sender, EventArgs e)
		{
			
			// TODO: Bu kod satırı 'projeDataSet11.Kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.kullanicilarTableAdapter.Fill(this.projeDataSet11.Kullanicilar);
			listele();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			connection.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("Select * from Kullanicilar where kullanici_adi like '" + textBox5.Text + "%'", connection);
			DataTable tablo2 = new DataTable();
			adtr.Fill(tablo2);
			dataGridView2.DataSource = tablo2;
			connection.Close();
		}

		private void fillToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.kullanicilarTableAdapter1.Fill(this.dataSet6.Kullanicilar);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}
	}
}
