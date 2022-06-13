
namespace WindowsFormsApp2
{
	partial class Satis
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.OdemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ProjeDataSet5 = new WindowsFormsApp2.ProjeDataSet5();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.OdemeTableAdapter = new WindowsFormsApp2.ProjeDataSet5TableAdapters.OdemeTableAdapter();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.OdemeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjeDataSet5)).BeginInit();
			this.SuspendLayout();
			// 
			// OdemeBindingSource
			// 
			this.OdemeBindingSource.DataMember = "Odeme";
			this.OdemeBindingSource.DataSource = this.ProjeDataSet5;
			// 
			// ProjeDataSet5
			// 
			this.ProjeDataSet5.DataSetName = "ProjeDataSet5";
			this.ProjeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Checked = false;
			this.dateTimePicker2.CustomFormat = " ";
			this.dateTimePicker2.Location = new System.Drawing.Point(127, 80);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker2.TabIndex = 73;
			this.dateTimePicker2.Value = new System.DateTime(2020, 12, 22, 0, 0, 0, 0);
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(206, 170);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(91, 38);
			this.button3.TabIndex = 72;
			this.button3.Text = "Guncelle";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(115, 170);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 39);
			this.button2.TabIndex = 71;
			this.button2.Text = "Sil";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(15, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 39);
			this.button1.TabIndex = 70;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(130, 114);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 69;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(127, 44);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 67;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 17);
			this.label5.TabIndex = 66;
			this.label5.Text = "Musteri Id:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 17);
			this.label3.TabIndex = 64;
			this.label3.Text = "Odeme Yontemi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 17);
			this.label2.TabIndex = 63;
			this.label2.Text = "Tarih:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(126, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 62;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 17);
			this.label1.TabIndex = 61;
			this.label1.Text = "Id:";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.Location = new System.Drawing.Point(603, 170);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(76, 36);
			this.button5.TabIndex = 84;
			this.button5.Text = "Guncelle";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button6.Location = new System.Drawing.Point(504, 170);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(76, 36);
			this.button6.TabIndex = 83;
			this.button6.Text = "Sil";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button7.Location = new System.Drawing.Point(393, 170);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(81, 38);
			this.button7.TabIndex = 82;
			this.button7.Text = "Kaydet";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(460, 127);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(100, 22);
			this.textBox10.TabIndex = 81;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(390, 128);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 17);
			this.label10.TabIndex = 80;
			this.label10.Text = "Model Id:";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(460, 86);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 22);
			this.textBox9.TabIndex = 79;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(390, 87);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 17);
			this.label9.TabIndex = 78;
			this.label9.Text = "Miktar:";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(460, 54);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 22);
			this.textBox8.TabIndex = 77;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(390, 55);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 17);
			this.label8.TabIndex = 76;
			this.label8.Text = "Fiyat";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(460, 12);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 22);
			this.textBox6.TabIndex = 75;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(390, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 74;
			this.label6.Text = "Satis Id:";
			// 
			// reportViewer1
			// 
			reportDataSource6.Name = "DataSet1";
			reportDataSource6.Value = this.OdemeBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report5.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(12, 239);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(526, 279);
			this.reportViewer1.TabIndex = 85;
			// 
			// OdemeTableAdapter
			// 
			this.OdemeTableAdapter.ClearBeforeFill = true;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(567, 435);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 22);
			this.textBox5.TabIndex = 88;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(575, 415);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 17);
			this.label7.TabIndex = 87;
			this.label7.Text = "Ad:";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new System.Drawing.Point(567, 463);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(81, 38);
			this.button4.TabIndex = 89;
			this.button4.Text = "Ara";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Satis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 634);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Satis";
			this.ShowIcon = false;
			this.Text = "Satış";
			this.Load += new System.EventHandler(this.Satis_Load);
			((System.ComponentModel.ISupportInitialize)(this.OdemeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjeDataSet5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource OdemeBindingSource;
		private ProjeDataSet5 ProjeDataSet5;
		private ProjeDataSet5TableAdapters.OdemeTableAdapter OdemeTableAdapter;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button4;
	}
}