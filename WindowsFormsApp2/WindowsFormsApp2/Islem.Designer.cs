
namespace WindowsFormsApp2
{
	partial class Islem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Islem));
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.islemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.islemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ıslemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.projeDataSet9 = new WindowsFormsApp2.ProjeDataSet9();
			this.islemTableAdapter = new WindowsFormsApp2.ProjeDataSet9TableAdapters.IslemTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ıslemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet9)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(77, 59);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 22);
			this.textBox6.TabIndex = 57;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 59);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 17);
			this.label7.TabIndex = 56;
			this.label7.Text = "Musteri id:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(77, 100);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 55;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.Location = new System.Drawing.Point(214, 97);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(89, 55);
			this.button3.TabIndex = 54;
			this.button3.Text = "Guncelle";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Location = new System.Drawing.Point(214, 59);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(89, 53);
			this.button2.TabIndex = 53;
			this.button2.Text = "Sil";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(213, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 52);
			this.button1.TabIndex = 52;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 17);
			this.label4.TabIndex = 51;
			this.label4.Text = "Islem id:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(77, 19);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 50;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 49;
			this.label3.Text = "Kaza Id:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(87, 297);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 22);
			this.textBox5.TabIndex = 66;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 302);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 17);
			this.label6.TabIndex = 65;
			this.label6.Text = "Personel Id";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(87, 264);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 64;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 266);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 17);
			this.label2.TabIndex = 63;
			this.label2.Text = "İşlem";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(87, 234);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 62;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 17);
			this.label5.TabIndex = 61;
			this.label5.Text = "İşlem id";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new System.Drawing.Point(192, 348);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 61);
			this.button4.TabIndex = 60;
			this.button4.Text = "Guncelle";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.Location = new System.Drawing.Point(102, 350);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(90, 58);
			this.button5.TabIndex = 59;
			this.button5.Text = "Sil";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button6.Location = new System.Drawing.Point(12, 350);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(90, 58);
			this.button6.TabIndex = 58;
			this.button6.Text = "Kaydet";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(975, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(125, 74);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 67;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(975, 412);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(125, 75);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 68;
			this.pictureBox2.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemidDataGridViewTextBoxColumn,
            this.islemDataGridViewTextBoxColumn,
            this.peridDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.ıslemBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(324, 97);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(629, 312);
			this.dataGridView1.TabIndex = 69;
			this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
			// 
			// islemidDataGridViewTextBoxColumn
			// 
			this.islemidDataGridViewTextBoxColumn.DataPropertyName = "islem_id";
			this.islemidDataGridViewTextBoxColumn.HeaderText = "islem_id";
			this.islemidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.islemidDataGridViewTextBoxColumn.Name = "islemidDataGridViewTextBoxColumn";
			this.islemidDataGridViewTextBoxColumn.ReadOnly = true;
			this.islemidDataGridViewTextBoxColumn.Width = 125;
			// 
			// islemDataGridViewTextBoxColumn
			// 
			this.islemDataGridViewTextBoxColumn.DataPropertyName = "islem";
			this.islemDataGridViewTextBoxColumn.HeaderText = "islem";
			this.islemDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.islemDataGridViewTextBoxColumn.Name = "islemDataGridViewTextBoxColumn";
			this.islemDataGridViewTextBoxColumn.Width = 125;
			// 
			// peridDataGridViewTextBoxColumn
			// 
			this.peridDataGridViewTextBoxColumn.DataPropertyName = "per_id";
			this.peridDataGridViewTextBoxColumn.HeaderText = "per_id";
			this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
			this.peridDataGridViewTextBoxColumn.Width = 125;
			// 
			// ıslemBindingSource
			// 
			this.ıslemBindingSource.DataMember = "Islem";
			this.ıslemBindingSource.DataSource = this.projeDataSet9;
			// 
			// projeDataSet9
			// 
			this.projeDataSet9.DataSetName = "ProjeDataSet9";
			this.projeDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// islemTableAdapter
			// 
			this.islemTableAdapter.ClearBeforeFill = true;
			// 
			// Islem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1112, 499);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Name = "Islem";
			this.ShowIcon = false;
			this.Text = "İşlem";
			this.Load += new System.EventHandler(this.Islem_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ıslemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet9)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ProjeDataSet9 projeDataSet9;
		private System.Windows.Forms.BindingSource ıslemBindingSource;
		private ProjeDataSet9TableAdapters.IslemTableAdapter islemTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn islemidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn islemDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
	}
}