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
	public partial class Servis : Form
	{
		public Servis()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=KÜBRA\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
		DataSet1TableAdapters.QueriesTableAdapter a = new DataSet1TableAdapters.QueriesTableAdapter();
		private void Servis_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'projeDataSet7.Servis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.servisTableAdapter.Fill(this.projeDataSet7.Servis);

		}

		public void veri()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select * from Servis", baglanti);
			DataSet ds = new DataSet();
			da.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}

		private void button1_Click(object sender, EventArgs e)
		{
			a.Ekle(Convert.ToInt32(textBox3.Text),Convert.ToDateTime(textBox4.Text),Convert.ToByte(textBox5.Text),textBox6.Text,decimal.Parse(textBox7.Text),decimal.Parse(textBox8.Text),decimal.Parse(textBox9.Text),Convert.ToInt32(textBox10.Text),Convert.ToInt32(textBox11.Text));
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			textBox9.Clear();
			textBox10.Clear();
			textBox11.Clear();
			veri();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			a.Sil(Convert.ToInt32(textBox1.Text));
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			textBox9.Clear();
			textBox10.Clear();
			textBox11.Clear();
			veri();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			a.Guncelle(Convert.ToInt32(textBox3.Text),Convert.ToDateTime(textBox4.Text),Convert.ToByte(textBox5.Text),textBox6.Text,decimal.Parse(textBox7.Text),decimal.Parse(textBox8.Text),decimal.Parse(textBox9.Text),Convert.ToInt32(textBox10.Text),Convert.ToInt32(textBox11.Text),Convert.ToInt32(textBox1.Text));
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			textBox9.Clear();
			textBox10.Clear();
			textBox11.Clear();
			veri();
		}

		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
			textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
			textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox11_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
