
namespace WindowsFormsApp2
{
	partial class Personel
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
			this.perAdBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Yeni = new WindowsFormsApp2.Yeni();
			this.PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personel2 = new WindowsFormsApp2.Personel2();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.personelTableAdapter1 = new WindowsFormsApp2.Personel2TableAdapters.PersonelTableAdapter();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.perAdTableAdapter = new WindowsFormsApp2.YeniTableAdapters.perAdTableAdapter();
			this.button6 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.PersonelTableAdapter = new WindowsFormsApp2.Personel2TableAdapters.PersonelTableAdapter();
			this.per1 = new WindowsFormsApp2.DataSet3TableAdapters.Per();
			this.per2 = new WindowsFormsApp2.DataSet3TableAdapters.Per();
			this.dataSet3 = new WindowsFormsApp2.DataSet3();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.projeDataSet10 = new WindowsFormsApp2.ProjeDataSet10();
			this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.personelTableAdapter2 = new WindowsFormsApp2.ProjeDataSet10TableAdapters.PersonelTableAdapter();
			this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pertcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perbolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.peradresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pertelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.perAdBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Yeni)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// perAdBindingSource
			// 
			this.perAdBindingSource.DataMember = "perAd";
			this.perAdBindingSource.DataSource = this.Yeni;
			// 
			// Yeni
			// 
			this.Yeni.DataSetName = "Yeni";
			this.Yeni.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// PersonelBindingSource
			// 
			this.PersonelBindingSource.DataMember = "Personel";
			this.PersonelBindingSource.DataSource = this.personel2;
			// 
			// personel2
			// 
			this.personel2.DataSetName = "Personel2";
			this.personel2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(114, 229);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(121, 44);
			this.button3.TabIndex = 57;
			this.button3.Text = "Sil";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(233, 229);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 44);
			this.button2.TabIndex = 56;
			this.button2.Text = "guncelle";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(7, 229);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 44);
			this.button1.TabIndex = 55;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(291, 175);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 22);
			this.textBox8.TabIndex = 54;
			this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(59, 175);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 22);
			this.textBox7.TabIndex = 53;
			this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(291, 124);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 22);
			this.textBox6.TabIndex = 52;
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(59, 129);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 22);
			this.textBox5.TabIndex = 51;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(291, 75);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 50;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(59, 75);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 49;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(288, 25);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 48;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(59, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 47;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(165, 175);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 17);
			this.label8.TabIndex = 46;
			this.label8.Text = "Telefon Numarası";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 180);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 17);
			this.label7.TabIndex = 45;
			this.label7.Text = "Adres:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(219, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 17);
			this.label6.TabIndex = 44;
			this.label6.Text = "Ucret";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 17);
			this.label5.TabIndex = 43;
			this.label5.Text = "Bölüm";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(219, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 17);
			this.label4.TabIndex = 42;
			this.label4.Text = "Soyad:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 17);
			this.label3.TabIndex = 41;
			this.label3.Text = "Ad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(230, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 17);
			this.label2.TabIndex = 40;
			this.label2.Text = "Tc:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 17);
			this.label1.TabIndex = 50;
			this.label1.Text = "Id:";
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.perAdBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report1.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(557, 12);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(510, 248);
			this.reportViewer1.TabIndex = 58;
			// 
			// personelTableAdapter1
			// 
			this.personelTableAdapter1.ClearBeforeFill = true;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(797, 295);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(100, 22);
			this.textBox10.TabIndex = 61;
			this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(674, 360);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 17);
			this.label10.TabIndex = 59;
			this.label10.Text = "Ad:";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new System.Drawing.Point(709, 335);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(82, 67);
			this.button4.TabIndex = 63;
			this.button4.Text = "Ara";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.Location = new System.Drawing.Point(815, 335);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(82, 67);
			this.button5.TabIndex = 64;
			this.button5.Text = "Listele";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// perAdTableAdapter
			// 
			this.perAdTableAdapter.ClearBeforeFill = true;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button6.Location = new System.Drawing.Point(924, 335);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(82, 67);
			this.button6.TabIndex = 65;
			this.button6.Text = "Id:";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(812, 420);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(125, 17);
			this.label9.TabIndex = 66;
			this.label9.Text = "Artandan Azalana:";
			// 
			// PersonelTableAdapter
			// 
			this.PersonelTableAdapter.ClearBeforeFill = true;
			// 
			// per1
			// 
			this.per1.ClearBeforeFill = true;
			// 
			// per2
			// 
			this.per2.ClearBeforeFill = true;
			// 
			// dataSet3
			// 
			this.dataSet3.DataSetName = "DataSet3";
			this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.pertcDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.perbolumDataGridViewTextBoxColumn,
            this.perucretDataGridViewTextBoxColumn,
            this.peradresDataGridViewTextBoxColumn,
            this.pertelDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.personelBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(18, 324);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(401, 175);
			this.dataGridView1.TabIndex = 67;
			this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
			// 
			// projeDataSet10
			// 
			this.projeDataSet10.DataSetName = "ProjeDataSet10";
			this.projeDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// personelBindingSource1
			// 
			this.personelBindingSource1.DataMember = "Personel";
			this.personelBindingSource1.DataSource = this.projeDataSet10;
			// 
			// personelTableAdapter2
			// 
			this.personelTableAdapter2.ClearBeforeFill = true;
			// 
			// peridDataGridViewTextBoxColumn
			// 
			this.peridDataGridViewTextBoxColumn.DataPropertyName = "per_id";
			this.peridDataGridViewTextBoxColumn.HeaderText = "per_id";
			this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
			this.peridDataGridViewTextBoxColumn.ReadOnly = true;
			this.peridDataGridViewTextBoxColumn.Width = 125;
			// 
			// pertcDataGridViewTextBoxColumn
			// 
			this.pertcDataGridViewTextBoxColumn.DataPropertyName = "per_tc";
			this.pertcDataGridViewTextBoxColumn.HeaderText = "per_tc";
			this.pertcDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.pertcDataGridViewTextBoxColumn.Name = "pertcDataGridViewTextBoxColumn";
			this.pertcDataGridViewTextBoxColumn.Width = 125;
			// 
			// peradDataGridViewTextBoxColumn
			// 
			this.peradDataGridViewTextBoxColumn.DataPropertyName = "per_ad";
			this.peradDataGridViewTextBoxColumn.HeaderText = "per_ad";
			this.peradDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
			this.peradDataGridViewTextBoxColumn.Width = 125;
			// 
			// persoyadDataGridViewTextBoxColumn
			// 
			this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "per_soyad";
			this.persoyadDataGridViewTextBoxColumn.HeaderText = "per_soyad";
			this.persoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
			this.persoyadDataGridViewTextBoxColumn.Width = 125;
			// 
			// perbolumDataGridViewTextBoxColumn
			// 
			this.perbolumDataGridViewTextBoxColumn.DataPropertyName = "per_bolum";
			this.perbolumDataGridViewTextBoxColumn.HeaderText = "per_bolum";
			this.perbolumDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perbolumDataGridViewTextBoxColumn.Name = "perbolumDataGridViewTextBoxColumn";
			this.perbolumDataGridViewTextBoxColumn.Width = 125;
			// 
			// perucretDataGridViewTextBoxColumn
			// 
			this.perucretDataGridViewTextBoxColumn.DataPropertyName = "per_ucret";
			this.perucretDataGridViewTextBoxColumn.HeaderText = "per_ucret";
			this.perucretDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perucretDataGridViewTextBoxColumn.Name = "perucretDataGridViewTextBoxColumn";
			this.perucretDataGridViewTextBoxColumn.Width = 125;
			// 
			// peradresDataGridViewTextBoxColumn
			// 
			this.peradresDataGridViewTextBoxColumn.DataPropertyName = "per_adres";
			this.peradresDataGridViewTextBoxColumn.HeaderText = "per_adres";
			this.peradresDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.peradresDataGridViewTextBoxColumn.Name = "peradresDataGridViewTextBoxColumn";
			this.peradresDataGridViewTextBoxColumn.Width = 125;
			// 
			// pertelDataGridViewTextBoxColumn
			// 
			this.pertelDataGridViewTextBoxColumn.DataPropertyName = "per_tel";
			this.pertelDataGridViewTextBoxColumn.HeaderText = "per_tel";
			this.pertelDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.pertelDataGridViewTextBoxColumn.Name = "pertelDataGridViewTextBoxColumn";
			this.pertelDataGridViewTextBoxColumn.Width = 125;
			// 
			// Personel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1087, 530);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Personel";
			this.Text = "Personel";
			this.Load += new System.EventHandler(this.Personel_Load);
			((System.ComponentModel.ISupportInitialize)(this.perAdBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Yeni)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private Personel2TableAdapters.PersonelTableAdapter personelTableAdapter1;
		private Personel2 personel2;
		private System.Windows.Forms.BindingSource perAdBindingSource;
		private Yeni Yeni;
		private YeniTableAdapters.perAdTableAdapter perAdTableAdapter;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.BindingSource PersonelBindingSource;
		private Personel2TableAdapters.PersonelTableAdapter PersonelTableAdapter;
		private DataSet3TableAdapters.Per per1;
		private DataSet3TableAdapters.Per per2;
		private DataSet3 dataSet3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ProjeDataSet10 projeDataSet10;
		private System.Windows.Forms.BindingSource personelBindingSource1;
		private ProjeDataSet10TableAdapters.PersonelTableAdapter personelTableAdapter2;
		private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pertcDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perbolumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perucretDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn peradresDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pertelDataGridViewTextBoxColumn;
	}
}