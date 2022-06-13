using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Personel : Form
	{
		public Personel()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
		Personel2TableAdapters.PersonelTableAdapter pe = new Personel2TableAdapters.PersonelTableAdapter();
		DataTable tablo = new DataTable();
		private void Personel_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'projeDataSet10.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.personelTableAdapter2.Fill(this.projeDataSet10.Personel);
			// TODO: Bu kod satırı 'personel2.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.PersonelTableAdapter.Fill(this.personel2.Personel);
			// TODO: Bu kod satırı 'Yeni.perAd' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.



		}

		public void veri()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select * from Personel", baglanti);
			DataSet ds = new DataSet();
			da.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			pe.Ekle(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, decimal.Parse(textBox6.Text), textBox7.Text, textBox8.Text);
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			veri();
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			pe.sil(Convert.ToInt32(textBox1.Text));
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			veri();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			pe.Guncelle(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, decimal.Parse(textBox6.Text), textBox7.Text, textBox8.Text, Convert.ToInt32(textBox1.Text));
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			veri();
		
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.perAdTableAdapter.Fill(this.Yeni.perAd, textBox10.Text);
			this.reportViewer1.RefreshReport();
			textBox10.Clear();
		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{

		}

		

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				this.perAdTableAdapter.FillBy1(this.Yeni.perAd);
				this.reportViewer1.RefreshReport();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				this.perAdTableAdapter.FillBy2(this.Yeni.perAd, ((int)(System.Convert.ChangeType(textBox10.Text, typeof(int)))));
				this.reportViewer1.RefreshReport();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		
		private void button7_Click(object sender, EventArgs e)
		{
			
		}

		private void reportViewer2_Load(object sender, EventArgs e)
		{

		}

		private void fillToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.per1.Fill(this.dataSet3.Per);
				this.reportViewer1.RefreshReport();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void fillToolStripButton_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.per1.Fill(this.dataSet3.Per);
				this.reportViewer1.RefreshReport();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

		}
	}
}
