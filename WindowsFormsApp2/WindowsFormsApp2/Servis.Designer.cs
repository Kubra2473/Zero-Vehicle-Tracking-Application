
namespace WindowsFormsApp2
{
	partial class Servis
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servis));
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.servisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.servistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviskmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sonrakitarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.garantiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.odenenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kalanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aracidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.projeDataSet7 = new WindowsFormsApp2.ProjeDataSet7();
			this.servisTableAdapter = new WindowsFormsApp2.ProjeDataSet7TableAdapters.ServisTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(88, 352);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(109, 22);
			this.textBox11.TabIndex = 87;
			this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(86, 313);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(109, 22);
			this.textBox10.TabIndex = 86;
			this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(114, 395);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(107, 50);
			this.button3.TabIndex = 85;
			this.button3.Text = "Sil";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(223, 395);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(102, 50);
			this.button2.TabIndex = 84;
			this.button2.Text = "Guncelle";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(11, 395);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 50);
			this.button1.TabIndex = 83;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(86, 285);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(109, 22);
			this.textBox9.TabIndex = 82;
			this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(1, 351);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 17);
			this.label11.TabIndex = 81;
			this.label11.Text = "Musteri Id:";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(86, 254);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(109, 22);
			this.textBox8.TabIndex = 80;
			this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 318);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 17);
			this.label10.TabIndex = 79;
			this.label10.Text = "Arac Id:";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(86, 216);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(109, 22);
			this.textBox7.TabIndex = 78;
			this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(86, 184);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(109, 22);
			this.textBox6.TabIndex = 77;
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(86, 141);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(109, 22);
			this.textBox5.TabIndex = 76;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(86, 103);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(109, 22);
			this.textBox4.TabIndex = 75;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(86, 67);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(109, 22);
			this.textBox3.TabIndex = 74;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(86, 39);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(109, 22);
			this.textBox2.TabIndex = 73;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(86, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(109, 22);
			this.textBox1.TabIndex = 72;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 284);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 17);
			this.label9.TabIndex = 71;
			this.label9.Text = "Kalan:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(1, 253);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 17);
			this.label8.TabIndex = 70;
			this.label8.Text = "Odenen:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 218);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 17);
			this.label7.TabIndex = 69;
			this.label7.Text = "Ucret:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(1, 188);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 68;
			this.label6.Text = "Aciklama:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(0, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 17);
			this.label5.TabIndex = 67;
			this.label5.Text = "Garanti:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(0, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 66;
			this.label4.Text = "Randevu:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 17);
			this.label3.TabIndex = 65;
			this.label3.Text = "Km:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 64;
			this.label2.Text = "Giris Tarih:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 17);
			this.label1.TabIndex = 63;
			this.label1.Text = "Id:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servisidDataGridViewTextBoxColumn,
            this.servistarihiDataGridViewTextBoxColumn,
            this.serviskmDataGridViewTextBoxColumn,
            this.sonrakitarihDataGridViewTextBoxColumn,
            this.garantiDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.odenenDataGridViewTextBoxColumn,
            this.kalanDataGridViewTextBoxColumn,
            this.aracidDataGridViewTextBoxColumn,
            this.musteriidDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.servisBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(379, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(768, 150);
			this.dataGridView1.TabIndex = 88;
			this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
			// 
			// servisidDataGridViewTextBoxColumn
			// 
			this.servisidDataGridViewTextBoxColumn.DataPropertyName = "servis_id";
			this.servisidDataGridViewTextBoxColumn.HeaderText = "servis_id";
			this.servisidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.servisidDataGridViewTextBoxColumn.Name = "servisidDataGridViewTextBoxColumn";
			this.servisidDataGridViewTextBoxColumn.ReadOnly = true;
			this.servisidDataGridViewTextBoxColumn.Width = 125;
			// 
			// servistarihiDataGridViewTextBoxColumn
			// 
			this.servistarihiDataGridViewTextBoxColumn.DataPropertyName = "servis_tarihi";
			this.servistarihiDataGridViewTextBoxColumn.HeaderText = "servis_tarihi";
			this.servistarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.servistarihiDataGridViewTextBoxColumn.Name = "servistarihiDataGridViewTextBoxColumn";
			this.servistarihiDataGridViewTextBoxColumn.Width = 125;
			// 
			// serviskmDataGridViewTextBoxColumn
			// 
			this.serviskmDataGridViewTextBoxColumn.DataPropertyName = "servis_km";
			this.serviskmDataGridViewTextBoxColumn.HeaderText = "servis_km";
			this.serviskmDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.serviskmDataGridViewTextBoxColumn.Name = "serviskmDataGridViewTextBoxColumn";
			this.serviskmDataGridViewTextBoxColumn.Width = 125;
			// 
			// sonrakitarihDataGridViewTextBoxColumn
			// 
			this.sonrakitarihDataGridViewTextBoxColumn.DataPropertyName = "sonraki_tarih";
			this.sonrakitarihDataGridViewTextBoxColumn.HeaderText = "sonraki_tarih";
			this.sonrakitarihDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sonrakitarihDataGridViewTextBoxColumn.Name = "sonrakitarihDataGridViewTextBoxColumn";
			this.sonrakitarihDataGridViewTextBoxColumn.Width = 125;
			// 
			// garantiDataGridViewTextBoxColumn
			// 
			this.garantiDataGridViewTextBoxColumn.DataPropertyName = "garanti";
			this.garantiDataGridViewTextBoxColumn.HeaderText = "garanti";
			this.garantiDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.garantiDataGridViewTextBoxColumn.Name = "garantiDataGridViewTextBoxColumn";
			this.garantiDataGridViewTextBoxColumn.Width = 125;
			// 
			// aciklamaDataGridViewTextBoxColumn
			// 
			this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
			this.aciklamaDataGridViewTextBoxColumn.HeaderText = "aciklama";
			this.aciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
			this.aciklamaDataGridViewTextBoxColumn.Width = 125;
			// 
			// ucretDataGridViewTextBoxColumn
			// 
			this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
			this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
			this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
			this.ucretDataGridViewTextBoxColumn.Width = 125;
			// 
			// odenenDataGridViewTextBoxColumn
			// 
			this.odenenDataGridViewTextBoxColumn.DataPropertyName = "odenen";
			this.odenenDataGridViewTextBoxColumn.HeaderText = "odenen";
			this.odenenDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.odenenDataGridViewTextBoxColumn.Name = "odenenDataGridViewTextBoxColumn";
			this.odenenDataGridViewTextBoxColumn.Width = 125;
			// 
			// kalanDataGridViewTextBoxColumn
			// 
			this.kalanDataGridViewTextBoxColumn.DataPropertyName = "kalan";
			this.kalanDataGridViewTextBoxColumn.HeaderText = "kalan";
			this.kalanDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.kalanDataGridViewTextBoxColumn.Name = "kalanDataGridViewTextBoxColumn";
			this.kalanDataGridViewTextBoxColumn.Width = 125;
			// 
			// aracidDataGridViewTextBoxColumn
			// 
			this.aracidDataGridViewTextBoxColumn.DataPropertyName = "arac_id";
			this.aracidDataGridViewTextBoxColumn.HeaderText = "arac_id";
			this.aracidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.aracidDataGridViewTextBoxColumn.Name = "aracidDataGridViewTextBoxColumn";
			this.aracidDataGridViewTextBoxColumn.Width = 125;
			// 
			// musteriidDataGridViewTextBoxColumn
			// 
			this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteri_id";
			this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteri_id";
			this.musteriidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
			this.musteriidDataGridViewTextBoxColumn.Width = 125;
			// 
			// servisBindingSource
			// 
			this.servisBindingSource.DataMember = "Servis";
			this.servisBindingSource.DataSource = this.projeDataSet7;
			// 
			// projeDataSet7
			// 
			this.projeDataSet7.DataSetName = "ProjeDataSet7";
			this.projeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// servisTableAdapter
			// 
			this.servisTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(817, 215);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(404, 266);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 89;
			this.pictureBox1.TabStop = false;
			// 
			// Servis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1223, 485);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Servis";
			this.ShowIcon = false;
			this.Text = "Servis";
			this.Load += new System.EventHandler(this.Servis_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ProjeDataSet7 projeDataSet7;
		private System.Windows.Forms.BindingSource servisBindingSource;
		private ProjeDataSet7TableAdapters.ServisTableAdapter servisTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn servisidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn servistarihiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviskmDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sonrakitarihDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn garantiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn odenenDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kalanDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aracidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}