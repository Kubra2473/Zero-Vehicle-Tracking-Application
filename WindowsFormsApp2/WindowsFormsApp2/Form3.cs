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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
		Form2 f2 = (Form2)Application.OpenForms["Form2"];

		private void Form3_Load(object sender, EventArgs e)
		{
            if (f2.yetki == "1")
            {

            }
            if (f2.yetki == "2")
            {
                button5.Hide();
                button1.Hide();
                button6.Hide();
                button8.Hide();
                button7.Hide();
                button2.Hide();


            }
            if (f2.yetki == "3")
            {
                button6.Hide();
                button8.Hide();
                button3.Hide();
                button4.Hide();
                button1.Hide();
                button7.Hide();
                button2.Hide();
            }
        }

		private void button4_Click(object sender, EventArgs e)
		{
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

		private void button5_Click(object sender, EventArgs e)
		{
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Menu ekle = new Menu();
            ekle.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

		private void button7_Click(object sender, EventArgs e)
		{
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

		private void button3_Click(object sender, EventArgs e)
		{
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
        private void button6_Click(object sender, EventArgs e)
		{
            string komut = "backup database model to disk='proje2.bak'";
            SqlCommand b = new SqlCommand(komut, baglanti);
            baglanti.Open();
            b.ExecuteNonQuery();
            baglanti.Close();
        }

		private void button8_Click(object sender, EventArgs e)
		{

            saveFileDialog1.Filter = "Backup Dosyası|* .bak";
            saveFileDialog1.Title = "Yedeklenmiş bak dosyasını seçin";
            saveFileDialog1.ShowDialog();
        }
	}
}
