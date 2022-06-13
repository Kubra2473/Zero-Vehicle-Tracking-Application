
namespace WindowsFormsApp2
{
	partial class Form8
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.kullaniciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kullaniciadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yetkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.projeDataSet11 = new WindowsFormsApp2.ProjeDataSet11();
			this.sil = new System.Windows.Forms.Button();
			this.kullanicilarTableAdapter1 = new WindowsFormsApp2.DataSet6TableAdapters.KullanicilarTableAdapter();
			this.dataSet6 = new WindowsFormsApp2.DataSet6();
			this.kullanicilarTableAdapter = new WindowsFormsApp2.ProjeDataSet11TableAdapters.KullanicilarTableAdapter();
			this.projeDataSet12 = new WindowsFormsApp2.ProjeDataSet12();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet12)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.dataGridView2);
			this.groupBox1.Controls.Add(this.sil);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(943, 405);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kullanıcı Sil";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(203, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(258, 25);
			this.label5.TabIndex = 11;
			this.label5.Text = "Kullanıcı Adına Göre Arama:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(484, 19);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 30);
			this.textBox5.TabIndex = 10;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciidDataGridViewTextBoxColumn,
            this.kullaniciadiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.yetkiDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.kullanicilarBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(163, 78);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(554, 254);
			this.dataGridView2.TabIndex = 9;
			// 
			// kullaniciidDataGridViewTextBoxColumn
			// 
			this.kullaniciidDataGridViewTextBoxColumn.DataPropertyName = "kullanici_id";
			this.kullaniciidDataGridViewTextBoxColumn.HeaderText = "kullanici_id";
			this.kullaniciidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.kullaniciidDataGridViewTextBoxColumn.Name = "kullaniciidDataGridViewTextBoxColumn";
			this.kullaniciidDataGridViewTextBoxColumn.Width = 125;
			// 
			// kullaniciadiDataGridViewTextBoxColumn
			// 
			this.kullaniciadiDataGridViewTextBoxColumn.DataPropertyName = "kullanici_adi";
			this.kullaniciadiDataGridViewTextBoxColumn.HeaderText = "kullanici_adi";
			this.kullaniciadiDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.kullaniciadiDataGridViewTextBoxColumn.Name = "kullaniciadiDataGridViewTextBoxColumn";
			this.kullaniciadiDataGridViewTextBoxColumn.Width = 125;
			// 
			// sifreDataGridViewTextBoxColumn
			// 
			this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
			this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
			this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
			this.sifreDataGridViewTextBoxColumn.Width = 125;
			// 
			// yetkiDataGridViewTextBoxColumn
			// 
			this.yetkiDataGridViewTextBoxColumn.DataPropertyName = "yetki";
			this.yetkiDataGridViewTextBoxColumn.HeaderText = "yetki";
			this.yetkiDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.yetkiDataGridViewTextBoxColumn.Name = "yetkiDataGridViewTextBoxColumn";
			this.yetkiDataGridViewTextBoxColumn.Width = 125;
			// 
			// kullanicilarBindingSource
			// 
			this.kullanicilarBindingSource.DataMember = "Kullanicilar";
			this.kullanicilarBindingSource.DataSource = this.projeDataSet11;
			// 
			// projeDataSet11
			// 
			this.projeDataSet11.DataSetName = "ProjeDataSet11";
			this.projeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sil
			// 
			this.sil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.sil.Location = new System.Drawing.Point(775, 291);
			this.sil.Name = "sil";
			this.sil.Size = new System.Drawing.Size(99, 41);
			this.sil.TabIndex = 8;
			this.sil.Text = "Sil";
			this.sil.UseVisualStyleBackColor = false;
			this.sil.Click += new System.EventHandler(this.sil_Click);
			// 
			// kullanicilarTableAdapter1
			// 
			this.kullanicilarTableAdapter1.ClearBeforeFill = true;
			// 
			// dataSet6
			// 
			this.dataSet6.DataSetName = "DataSet6";
			this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// kullanicilarTableAdapter
			// 
			this.kullanicilarTableAdapter.ClearBeforeFill = true;
			// 
			// projeDataSet12
			// 
			this.projeDataSet12.DataSetName = "ProjeDataSet12";
			this.projeDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 439);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form8";
			this.ShowIcon = false;
			this.Text = "Sil";
			this.Load += new System.EventHandler(this.Form8_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet12)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button sil;
		private DataSet6TableAdapters.KullanicilarTableAdapter kullanicilarTableAdapter1;
		private DataSet6 dataSet6;
		private ProjeDataSet11 projeDataSet11;
		private System.Windows.Forms.BindingSource kullanicilarBindingSource;
		private ProjeDataSet11TableAdapters.KullanicilarTableAdapter kullanicilarTableAdapter;
		private ProjeDataSet12 projeDataSet12;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciadiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yetkiDataGridViewTextBoxColumn;
	}
}