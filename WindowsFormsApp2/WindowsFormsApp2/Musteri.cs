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
	public partial class Musteri : Form
	{
		public Musteri()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
		private void button2_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			String kayit = "insert into Musteri(musteri_ad,musteri_soyad,musteri_tel,musteri_eposta,musteri_adres) values (@musteri_ad,@musteri_soyad,@musteri_tel,@musteri_eposta,@musteri_adres)";
			SqlCommand komut = new SqlCommand(kayit, baglanti);
			komut.Parameters.AddWithValue("@musteri_ad", textBox1.Text);
			komut.Parameters.AddWithValue("@musteri_soyad", textBox2.Text);
			komut.Parameters.AddWithValue("@musteri_tel", textBox3.Text);
			komut.Parameters.AddWithValue("@musteri_eposta", textBox4.Text);
			komut.Parameters.AddWithValue("@musteri_adres", textBox5.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("delete from Musteri where musteri_id=@musteri_id", baglanti);
			komut.Parameters.AddWithValue("@musteri_id", textBox6.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox6.Clear();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string guncelle = "UPDATE Musteri SET musteri_ad=@musteri_ad,musteri_soyad=@musteri_soyad,musteri_tel=@musteri_tel,musteri_eposta=@musteri_eposta,musteri_adres=@musteri_adres WHERE musteri_id=@musteri_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@musteri_id", Convert.ToInt32(textBox6.Text));
			komut.Parameters.AddWithValue("@musteri_ad", textBox1.Text);
			komut.Parameters.AddWithValue("@musteri_soyad", textBox2.Text);
			komut.Parameters.AddWithValue("@musteri_tel", textBox3.Text);
			komut.Parameters.AddWithValue("@musteri_eposta", textBox4.Text);
			komut.Parameters.AddWithValue("@musteri_adres", textBox5.Text);
			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
		}

		private void Musteri_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'projeDataSet8.Guncelleme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.guncellemeTableAdapter.Fill(this.projeDataSet8.Guncelleme);
			// TODO: Bu kod satırı 'DataSet4.silinenmusteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.silinenmusteriTableAdapter.Fill(this.DataSet4.silinenmusteri);



		}

		private void fillToolStripButton_Click(object sender, EventArgs e)
		{
			

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.AdandSoyadmTableAdapter.Fill(this.ProjeDataSet3.AdandSoyadm, textBox8.Text, textBox7.Text);

				this.reportViewer1.RefreshReport();
				textBox7.Clear();
				textBox8.Clear();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				this.AdandSoyadmTableAdapter.FillBy(this.ProjeDataSet3.AdandSoyadm);
				this.reportViewer1.RefreshReport();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		

		private void reportViewer2_Load(object sender, EventArgs e)
		{

		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}

		

		

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				this.silinenmusteriTableAdapter.FillBy(this.DataSet4.silinenmusteri);
				this.reportViewer2.RefreshReport();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		
		

		private void reportViewer3_Load(object sender, EventArgs e)
		{

		}

		private void birlesimToolStripButton_Click(object sender, EventArgs e)
		{
			

		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				this.silinenmusteriTableAdapter1.Birlesim(this.dataSet1.silinenmusteri);
				this.reportViewer3.RefreshReport();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}
	}
}
