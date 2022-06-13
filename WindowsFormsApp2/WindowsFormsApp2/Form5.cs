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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");

		//DataTable tablo = new DataTable();
	/*	private void listele()
		{
			connection.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("Select * from Musteri", connection);
			adtr.Fill(tablo);
			dataGridView1.DataSource = tablo;
			connection.Close();
		} */
		private void button1_Click(object sender, EventArgs e)
		{
			// listele();
			DataTable tablo = new DataTable();
			connection.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("Select * from Musteri", connection);
			adtr.Fill(tablo);
			dataGridView1.DataSource = tablo;
			connection.Close();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			DataTable tablo2 = new DataTable();
			connection.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("Select * from Kullanicilar", connection);
			adtr.Fill(tablo2);
			dataGridView1.DataSource = tablo2;
			connection.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DataTable tablo3 = new DataTable();
			connection.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("Select * from Personel", connection);
			adtr.Fill(tablo3);
			dataGridView1.DataSource = tablo3;
			connection.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DataTable tablo4 = new DataTable();
			connection.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("Select * from Model", connection);
			adtr.Fill(tablo4);
			dataGridView1.DataSource = tablo4;
			connection.Close();
		}
	}
}
