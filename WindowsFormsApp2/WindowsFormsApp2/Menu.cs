using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Personel ekle = new Personel();
			ekle.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Islem ekle = new Islem();
			ekle.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Servis ekle = new Servis();
			ekle.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Model ekle = new Model();
			ekle.ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Bayi ekle = new Bayi();
			ekle.ShowDialog();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Arac ekle = new Arac();
			ekle.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Musteri ekle = new Musteri();
			ekle.ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Satis ekle = new Satis();
			ekle.ShowDialog();
		}
	}
}
