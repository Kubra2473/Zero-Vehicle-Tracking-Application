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
	public partial class Model : Form
	{
		public Model()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
		DataSet7TableAdapters.OzellikTableAdapter a = new DataSet7TableAdapters.OzellikTableAdapter();
		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			String kayit = "insert into Model(model_ad,adet,marka_id) values (@model_ad,@adet,@marka_id)";
			SqlCommand komut = new SqlCommand(kayit, baglanti);
			komut.Parameters.AddWithValue("@model_ad", textBox2.Text);
			komut.Parameters.AddWithValue("@adet", textBox3.Text);
			komut.Parameters.AddWithValue("@marka_id", textBox4.Text);

			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kayıt işlemi yapildi");
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			String sorgu = "DELETE FROM Model WHERE model_id=@model_id";
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			komut.Parameters.AddWithValue("@model_id", Convert.ToInt32(textBox1.Text));
			baglanti.Open();

			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string guncelle = "UPDATE Model SET model_ad=@model_ad,adet=@adet,marka_id=@marka_id WHERE model_id=@model_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@model_id", Convert.ToInt32(textBox1.Text));
			komut.Parameters.AddWithValue("@model_ad", textBox2.Text);
			komut.Parameters.AddWithValue("@adet", textBox3.Text);
			komut.Parameters.AddWithValue("@marka_id", textBox4.Text);

			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			String kayit = "insert into AracOzellik(ozellik) values (@ozellik)";
			SqlCommand komut = new SqlCommand(kayit, baglanti);
			komut.Parameters.AddWithValue("@ozellik", textBox6.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox6.Clear();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			String sorgu = "DELETE FROM AracOzellik WHERE aracozellik_id=@aracozellik_id";
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			komut.Parameters.AddWithValue("@aracozellik_id", Convert.ToInt32(textBox5.Text));
			baglanti.Open();

			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox5.Clear();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string guncelle = "UPDATE AracOzellik SET ozellik=@ozellik WHERE aracozellik_id=@aracozellik_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@aracozellik_id", Convert.ToInt32(textBox5.Text));
			komut.Parameters.AddWithValue("@ozellik", textBox6.Text);
			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox5.Clear();
			textBox6.Clear();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			a.ekle(Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text));
			textBox9.Clear();
			textBox8.Clear();
			textBox7.Clear();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			String sorgu = "DELETE FROM Ozellik WHERE ozellik_id=@ozellik_id";
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			komut.Parameters.AddWithValue("@ozellik_id", Convert.ToInt32(textBox9.Text));
			baglanti.Open();

			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox9.Clear();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			string guncelle = "UPDATE Ozellik SET aracozellik_id=@aracozellik_id,model_id=@model_id WHERE ozellik_id=@ozellik_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@ozellik_id", Convert.ToInt32(textBox9.Text));
			komut.Parameters.AddWithValue("@aracozellik_id", textBox8.Text);
			komut.Parameters.AddWithValue("@model_id", textBox7.Text);

			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox9.Clear();
			textBox8.Clear();
			textBox7.Clear();
		}

		private void Model_Load(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
