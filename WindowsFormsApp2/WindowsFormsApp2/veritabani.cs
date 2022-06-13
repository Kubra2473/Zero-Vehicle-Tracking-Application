using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    /* class veritabani
	{
        SqlConnection connection = new SqlConnection("Data Source = KÜBRA\\SQLEXPRESS; Initial Catalog = Proje; Integrated Security = True");
        SqlCommand command;
        SqlDataReader reader;


        public void girisYap(string k_adi, string sifre, Form frm1)
        {

            command = new SqlCommand("Select * from Kullanicilar where kullanici_adi='" + k_adi + "' and sifre='" + sifre + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı!");

            }
            else
            {
                MessageBox.Show("Hatali giris!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connection.Close();
            command.Dispose();
        }

    
} */
}
