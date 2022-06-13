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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}
        SqlConnection connection = new SqlConnection("Data Source = KÜBRA\\SQLEXPRESS; Initial Catalog = Proje; Integrated Security = True");

        DataTable tablo = new DataTable();
        private void listele()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Kullanicilar", connection);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            /*  connection.Open();
             SqlCommand komut = new SqlCommand("insert into Kullanicilar(kullanici_id, kullanici_adi, sifre, yetki) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", connection);
             komut.ExecuteNonQuery();
             connection.Close();
             MessageBox.Show("Kayıt Eklendi", "Kayıt");
             dataGridView1.Refresh(); */
            if (button1.Text == "Ekle")
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("insert into Kullanicilar (kullanici_id, kullanici_adi, sifre, yetki) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", connection);

                komut.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt Eklendi", "Kayıt");
                //buraları ekle //
                tablo.Clear();
                listele();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
            if (button1.Text == "Güncelle")
            {
                connection.Open();
                SqlCommand komut2 = new SqlCommand("update Kullanicilar set kullanici_adi='" + textBox2.Text + "',sifre='" + textBox3.Text + "',yetki='" + textBox4.Text + "'where kullanici_id='" + textBox1.Text + "'", connection);

                komut2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt Güncellendi", "Kayıt");
                //buraları ekle //
                tablo.Clear();
                listele();
                button1.Text = "Ekle";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }

            
        }

        private void Form4_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            textBox1.Text = dataGridView1.CurrentRow.Cells["kullanici_id"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["kullanici_adi"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["yetki"].Value.ToString();
            button1.Text = "Güncelle";
        }
	}
}
