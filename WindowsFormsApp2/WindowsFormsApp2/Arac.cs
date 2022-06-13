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
	public partial class Arac : Form
	{
		public Arac()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			String kayit = "insert into Arac (plaka,model_id,uretim_yili) values (@plaka,@model_id,@uretim_yili)";
			SqlCommand komut = new SqlCommand(kayit, baglanti);
			komut.Parameters.AddWithValue("@plaka", textBox2.Text);
			komut.Parameters.AddWithValue("@model_id", textBox3.Text);
			komut.Parameters.AddWithValue("@uretim_yili", dateTimePicker1.Value);

			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("delete from Arac where arac_id=@arac_id", baglanti);
			komut.Parameters.AddWithValue("@arac_id", textBox1.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string guncelle = "UPDATE Arac SET plaka=@plaka,model_id=@model_id,uretim_yili=@uretim_yili WHERE arac_id=@arac_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@arac_id", Convert.ToInt32(textBox1.Text));
			komut.Parameters.AddWithValue("@plaka", textBox2.Text);
			komut.Parameters.AddWithValue("@model_id", textBox3.Text);
			komut.Parameters.AddWithValue("@uretim_yili", dateTimePicker1.Value);
			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}

		private void Arac_Load(object sender, EventArgs e)
		{

		}
	}
}
