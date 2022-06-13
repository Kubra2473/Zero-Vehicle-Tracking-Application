using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2, 1] = dataGridView1[i, j].Value;
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Mno", "Müşteri No");
            dataGridView1.Columns.Add("Adi_Soyadi", "Adı Soyadı");
            dataGridView1.Columns.Add("Telefon", "Telefon");
            dataGridView1.Columns.Add("Sehir", "Şehir");
            dataGridView1.Rows.Add(1, "Murat Say", "5366985664", "Ankara");
            dataGridView1.Rows.Add(2, "Ali Ak", "5366235964", "İstanbul");
            dataGridView1.Rows.Add(3, "Veri Kara", "5368924664", "Denizli");
            dataGridView1.Rows.Add(4, "Ayşe Son", "5366923485", "Konya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.SelectedRows[i].Cells.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[i + 1, j + 1];
                    alan2.Cells[2, 1] = dataGridView1.SelectedRows[i].Cells[j].Value;
                }
            }
        }
    }
}
