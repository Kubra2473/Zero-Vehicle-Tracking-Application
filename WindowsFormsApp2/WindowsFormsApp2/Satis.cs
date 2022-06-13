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
	public partial class Satis : Form
	{
		public Satis()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
		DataSet8TableAdapters.OdemeTableAdapter a = new DataSet8TableAdapters.OdemeTableAdapter();
		private void button1_Click(object sender, EventArgs e)
		{
			a.Ekle(textBox2.Text, Convert.ToInt32(textBox4.Text));
			baglanti.Close();
			textBox4.Clear();
			textBox2.Clear();
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("delete from Odeme where odeme_id=@odeme_id", baglanti);
			komut.Parameters.AddWithValue("@odeme_id", textBox1.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string guncelle = "UPDATE Odeme SET odeme_sekli=@odeme_sekli,musteri_id=@musteri_id WHERE odeme_id=@odeme_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@odeme_id", Convert.ToInt32(textBox1.Text));
			komut.Parameters.AddWithValue("@odeme_sekli", textBox2.Text);
			komut.Parameters.AddWithValue("@musteri_id", textBox4.Text);
			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox4.Clear();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			String kayit = "insert into ArabaSatis (arac_fiyati,miktar,model_id) values (@arac_fiyati,@miktar,@model_id)";
			SqlCommand komut = new SqlCommand(kayit, baglanti);
			komut.Parameters.AddWithValue("@arac_fiyati", Convert.ToInt32(textBox8.Text));
			komut.Parameters.AddWithValue("@miktar", textBox9.Text);
			komut.Parameters.AddWithValue("@model_id", textBox10.Text);

			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox8.Clear();
			textBox9.Clear();
			textBox10.Clear();
		}

		private void button6_Click(object sender, EventArgs e)
		{

			baglanti.Open();
			SqlCommand komut = new SqlCommand("delete from ArabaSatis where arabasatis_id=@arabasatis_id", baglanti);
			komut.Parameters.AddWithValue("@arabasatis_id", textBox6.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox6.Clear();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string guncelle = "UPDATE ArabaSatis SET arac_fiyati=@arac_fiyati,miktar=@miktar,model_id=@model_id WHERE arabasatis_id=@arabasatis_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@arabasatis_id", Convert.ToInt32(textBox6.Text));
			komut.Parameters.AddWithValue("@arac_fiyati", textBox8.Text);
			komut.Parameters.AddWithValue("@miktar", textBox9.Text);
			komut.Parameters.AddWithValue("@model_id", textBox10.Text);
			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox6.Clear();
			textBox8.Clear();
			textBox9.Clear();
			textBox10.Clear();
		}

		private void Satis_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'ProjeDataSet5.Odeme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.OdemeTableAdapter.Fill(this.ProjeDataSet5.Odeme);

			
		}

		

		private void fillByToolStripButton_Click_1(object sender, EventArgs e)
		{
			

		}

		private void musteri_adToolStripLabel_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.OdemeTableAdapter.FillBy(this.ProjeDataSet5.Odeme, textBox5.Text);
				this.reportViewer1.RefreshReport();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
