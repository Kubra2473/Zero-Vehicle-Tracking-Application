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
	public partial class Islem : Form
	{
		public Islem()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
		Islem2TableAdapters.QueriesTableAdapter a = new Islem2TableAdapters.QueriesTableAdapter();
		private void Islem_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'projeDataSet9.Islem' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.islemTableAdapter.Fill(this.projeDataSet9.Islem);

		}
		public void veri()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select * from Kaza", baglanti);
			DataSet ds = new DataSet();
			da.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}

		public void veri2()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select * from Islem", baglanti);
			DataSet ds = new DataSet();
			da.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}



		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			String kayit = "insert into Kaza (musteri_id,islem_id) values (@musteri_id,@islem_id)";
			SqlCommand komut = new SqlCommand(kayit, baglanti);
			komut.Parameters.AddWithValue("@musteri_id", textBox6.Text);
			komut.Parameters.AddWithValue("@islem_id", textBox4.Text);


			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox4.Clear();
			textBox6.Clear();
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			String sorgu = "DELETE FROM Kaza WHERE kaza_id=@kaza_id";
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			komut.Parameters.AddWithValue("@kaza_id", Convert.ToInt32(textBox3.Text));
			baglanti.Open();

			komut.ExecuteNonQuery();
			baglanti.Close();

			textBox3.Clear();
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string guncelle = "UPDATE Kaza SET musteri_id=@musteri_id,islem_id=@islem_id WHERE kaza_id=@kaza_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@kaza_id", Convert.ToInt32(textBox3.Text));
			komut.Parameters.AddWithValue("@musteri_id", textBox6.Text);
			komut.Parameters.AddWithValue("@islem_id", textBox4.Text);

			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox4.Clear();
			textBox6.Clear();
			textBox3.Clear();
			
		}

		private void button6_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			String kayit = "insert into Islem (islem,per_id) values (@islem,@per_id)";
			SqlCommand komut = new SqlCommand(kayit, baglanti);
			komut.Parameters.AddWithValue("@islem", textBox1.Text);
			komut.Parameters.AddWithValue("@per_id", textBox5.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox1.Clear();
			textBox5.Clear();
			veri2();
		
		}

		private void button5_Click(object sender, EventArgs e)
		{
			a.Sil(Convert.ToInt32(textBox2.Text));
			textBox5.Clear();
			textBox2.Clear();
			textBox1.Clear();
			veri2();
		
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string guncelle = "UPDATE Islem SET islem=@islem,per_id=@per_id WHERE islem_id=@islem_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@islem_id", Convert.ToInt32(textBox2.Text));
			komut.Parameters.AddWithValue("@islem", textBox1.Text);
			komut.Parameters.AddWithValue("@per_id", textBox5.Text);

			baglanti.Open();
			komut.ExecuteNonQuery();
			baglanti.Close();
			textBox5.Clear();
			textBox2.Clear();
			textBox1.Clear();
			veri2();
		}

		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
