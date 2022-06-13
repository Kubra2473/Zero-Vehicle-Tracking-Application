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
	public partial class Bayi : Form
	{
		public Bayi()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			String kayit = "insert into Bayi (bayi_tel,bayi_adres,bayi_eposta,per_id) values (@bayi_tel,@bayi_adres,@bayi_eposta,@per_id)";
			SqlCommand komut = new SqlCommand(kayit, baglanti);
			komut.Parameters.AddWithValue("@bayi_tel", textBox2.Text);
			komut.Parameters.AddWithValue("@bayi_adres", textBox3.Text);
			komut.Parameters.AddWithValue("@bayi_eposta", textBox4.Text);
			komut.Parameters.AddWithValue("@per_id", textBox5.Text);
			
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			String sorgu = "DELETE FROM Bayi WHERE bayi_id=@bayi_id";
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			komut.Parameters.AddWithValue("@bayi_id", Convert.ToInt32(textBox1.Text));
			baglanti.Open();

			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{

			string guncelle = "UPDATE Bayi SET bayi_tel=@bayi_tel,bayi_adres=@bayi_adres,bayi_eposta=@bayi_eposta,per_id=@per_id WHERE bayi_id=@bayi_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@bayi_id", Convert.ToInt32(textBox1.Text));
			komut.Parameters.AddWithValue("@bayi_tel", textBox2.Text);
			komut.Parameters.AddWithValue("@bayi_adres", textBox3.Text);
			komut.Parameters.AddWithValue("@bayi_eposta", textBox4.Text);
			komut.Parameters.AddWithValue("@per_id", textBox5.Text);
			
			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			
		}

		private void Bayi_Load(object sender, EventArgs e)
		{

		}
	}
}
