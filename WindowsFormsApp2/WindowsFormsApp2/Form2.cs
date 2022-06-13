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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
        SqlConnection connection = new SqlConnection("Data Source = KÜBRA\\SQLEXPRESS; Initial Catalog = Proje; Integrated Security = True");

        public string yetki;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand("Select * from Kullanicilar where kullanici_adi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
                yetki = reader["yetki"].ToString();
                Form3 f3 = new Form3();
                f3.ShowDialog();


            }
            else
            {
                MessageBox.Show("Hatali giris!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connection.Close();
            command.Dispose();
        }

     

		private void Form2_Load(object sender, EventArgs e)
		{
			textBox2.PasswordChar = '*';
		}
	}
}
