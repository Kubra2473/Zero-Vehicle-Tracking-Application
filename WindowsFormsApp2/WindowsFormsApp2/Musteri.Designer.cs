
namespace WindowsFormsApp2
{
	partial class Musteri
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.AdandSoyadmBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ProjeDataSet3 = new WindowsFormsApp2.ProjeDataSet3();
			this.silinenmusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DataSet4 = new WindowsFormsApp2.DataSet4();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.AdandSoyadmTableAdapter = new WindowsFormsApp2.ProjeDataSet3TableAdapters.AdandSoyadmTableAdapter();
			this.projeDataSet4 = new WindowsFormsApp2.ProjeDataSet4();
			this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.silinenmusteriTableAdapter = new WindowsFormsApp2.DataSet4TableAdapters.silinenmusteriTableAdapter();
			this.button6 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.sayacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guncellemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.projeDataSet8 = new WindowsFormsApp2.ProjeDataSet8();
			this.guncellemeTableAdapter = new WindowsFormsApp2.ProjeDataSet8TableAdapters.GuncellemeTableAdapter();
			this.label9 = new System.Windows.Forms.Label();
			this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dataSet1 = new WindowsFormsApp2.DataSet1();
			this.silinenmusteriTableAdapter1 = new WindowsFormsApp2.DataSet1TableAdapters.silinenmusteriTableAdapter();
			this.tableAdapterManager = new WindowsFormsApp2.DataSet1TableAdapters.TableAdapterManager();
			this.button7 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.AdandSoyadmBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjeDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.silinenmusteriBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guncellemeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// AdandSoyadmBindingSource
			// 
			this.AdandSoyadmBindingSource.DataMember = "AdandSoyadm";
			this.AdandSoyadmBindingSource.DataSource = this.ProjeDataSet3;
			// 
			// ProjeDataSet3
			// 
			this.ProjeDataSet3.DataSetName = "ProjeDataSet3";
			this.ProjeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// silinenmusteriBindingSource
			// 
			this.silinenmusteriBindingSource.DataMember = "silinenmusteri";
			this.silinenmusteriBindingSource.DataSource = this.DataSet4;
			// 
			// DataSet4
			// 
			this.DataSet4.DataSetName = "DataSet4";
			this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new System.Drawing.Point(214, 88);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(131, 58);
			this.button4.TabIndex = 90;
			this.button4.Text = "Guncelle";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(214, 51);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(131, 61);
			this.button3.TabIndex = 89;
			this.button3.Text = "Kayit Sil";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(214, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 64);
			this.button2.TabIndex = 88;
			this.button2.Text = "Kayit Ekle";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(88, 9);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 22);
			this.textBox6.TabIndex = 87;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 17);
			this.label6.TabIndex = 86;
			this.label6.Text = "Musteri No:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(88, 152);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 22);
			this.textBox5.TabIndex = 85;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 17);
			this.label5.TabIndex = 84;
			this.label5.Text = "Adres";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(88, 124);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 83;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 17);
			this.label4.TabIndex = 82;
			this.label4.Text = "Eposta";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(88, 96);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 81;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 17);
			this.label3.TabIndex = 80;
			this.label3.Text = "Telefon:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(88, 68);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 79;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 78;
			this.label2.Text = "Soyad:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(88, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 77;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 17);
			this.label1.TabIndex = 76;
			this.label1.Text = "Ad:";
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.AdandSoyadmBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report3.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(-6, 260);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(368, 203);
			this.reportViewer1.TabIndex = 91;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(438, 373);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 22);
			this.textBox7.TabIndex = 95;
			this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(388, 378);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 17);
			this.label7.TabIndex = 94;
			this.label7.Text = "Soyad:";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(438, 345);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 22);
			this.textBox8.TabIndex = 93;
			this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(388, 350);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 17);
			this.label8.TabIndex = 92;
			this.label8.Text = "Ad:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(391, 406);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 43);
			this.button1.TabIndex = 96;
			this.button1.Text = "Ara";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.Location = new System.Drawing.Point(391, 448);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(109, 43);
			this.button5.TabIndex = 97;
			this.button5.Text = "Listele";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// AdandSoyadmTableAdapter
			// 
			this.AdandSoyadmTableAdapter.ClearBeforeFill = true;
			// 
			// projeDataSet4
			// 
			this.projeDataSet4.DataSetName = "ProjeDataSet4";
			this.projeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer2
			// 
			reportDataSource2.Name = "DataSet1";
			reportDataSource2.Value = this.silinenmusteriBindingSource;
			this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
			this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report4.rdlc";
			this.reportViewer2.Location = new System.Drawing.Point(905, 12);
			this.reportViewer2.Name = "reportViewer2";
			this.reportViewer2.ServerReport.BearerToken = null;
			this.reportViewer2.Size = new System.Drawing.Size(387, 185);
			this.reportViewer2.TabIndex = 98;
			// 
			// silinenmusteriTableAdapter
			// 
			this.silinenmusteriTableAdapter.ClearBeforeFill = true;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button6.Location = new System.Drawing.Point(527, 215);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(91, 36);
			this.button6.TabIndex = 100;
			this.button6.Text = "Ara";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sayacDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.guncellemeBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(572, 419);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(222, 87);
			this.dataGridView1.TabIndex = 101;
			// 
			// sayacDataGridViewTextBoxColumn
			// 
			this.sayacDataGridViewTextBoxColumn.DataPropertyName = "sayac";
			this.sayacDataGridViewTextBoxColumn.HeaderText = "sayac";
			this.sayacDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sayacDataGridViewTextBoxColumn.Name = "sayacDataGridViewTextBoxColumn";
			this.sayacDataGridViewTextBoxColumn.Width = 125;
			// 
			// guncellemeBindingSource
			// 
			this.guncellemeBindingSource.DataMember = "Guncelleme";
			this.guncellemeBindingSource.DataSource = this.projeDataSet8;
			// 
			// projeDataSet8
			// 
			this.projeDataSet8.DataSetName = "ProjeDataSet8";
			this.projeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// guncellemeTableAdapter
			// 
			this.guncellemeTableAdapter.ClearBeforeFill = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(484, -2);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(101, 17);
			this.label9.TabIndex = 102;
			this.label9.Text = "Silinen Kayıtlar";
			// 
			// reportViewer3
			// 
			reportDataSource3.Name = "DataSet1";
			reportDataSource3.Value = this.silinenmusteriBindingSource;
			this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
			this.reportViewer3.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report6.rdlc";
			this.reportViewer3.Location = new System.Drawing.Point(438, 27);
			this.reportViewer3.Name = "reportViewer3";
			this.reportViewer3.ServerReport.BearerToken = null;
			this.reportViewer3.Size = new System.Drawing.Size(382, 192);
			this.reportViewer3.TabIndex = 103;
			this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// silinenmusteriTableAdapter1
			// 
			this.silinenmusteriTableAdapter1.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.PersonelTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button7.Location = new System.Drawing.Point(1056, 359);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(91, 36);
			this.button7.TabIndex = 106;
			this.button7.Text = "Ara";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Musteri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1320, 570);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.reportViewer3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.reportViewer2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Musteri";
			this.Text = "Musteri";
			this.Load += new System.EventHandler(this.Musteri_Load);
			((System.ComponentModel.ISupportInitialize)(this.AdandSoyadmBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjeDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.silinenmusteriBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guncellemeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource AdandSoyadmBindingSource;
		private ProjeDataSet3 ProjeDataSet3;
		private ProjeDataSet3TableAdapters.AdandSoyadmTableAdapter AdandSoyadmTableAdapter;
		private System.Windows.Forms.Button button5;
		private ProjeDataSet4 projeDataSet4;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
		private System.Windows.Forms.BindingSource silinenmusteriBindingSource;
		private DataSet4 DataSet4;
		private DataSet4TableAdapters.silinenmusteriTableAdapter silinenmusteriTableAdapter;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ProjeDataSet8 projeDataSet8;
		private System.Windows.Forms.BindingSource guncellemeBindingSource;
		private ProjeDataSet8TableAdapters.GuncellemeTableAdapter guncellemeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn sayacDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label9;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
		private DataSet1 dataSet1;
		private DataSet1TableAdapters.silinenmusteriTableAdapter silinenmusteriTableAdapter1;
		private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button button7;
	}
}