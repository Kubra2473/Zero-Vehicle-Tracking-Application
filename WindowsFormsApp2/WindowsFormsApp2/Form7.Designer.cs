
namespace WindowsFormsApp2
{
	partial class Form7
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.musteriadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.musterisoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.musteritelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.musteriepostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.musteriadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.projeDataSet6 = new WindowsFormsApp2.ProjeDataSet6();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.musteriTableAdapter = new WindowsFormsApp2.ProjeDataSet6TableAdapters.MusteriTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet6)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(287, 285);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(83, 28);
			this.button2.TabIndex = 19;
			this.button2.Text = "İmport";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(585, 252);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(43, 33);
			this.button1.TabIndex = 18;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(146, 257);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(433, 22);
			this.textBox1.TabIndex = 17;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(146, 285);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(114, 24);
			this.comboBox1.TabIndex = 16;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriidDataGridViewTextBoxColumn,
            this.musteriadDataGridViewTextBoxColumn,
            this.musterisoyadDataGridViewTextBoxColumn,
            this.musteritelDataGridViewTextBoxColumn,
            this.musteriepostaDataGridViewTextBoxColumn,
            this.musteriadresDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.musteriBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(31, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(812, 229);
			this.dataGridView1.TabIndex = 15;
			// 
			// musteriidDataGridViewTextBoxColumn
			// 
			this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteri_id";
			this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteri_id";
			this.musteriidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
			this.musteriidDataGridViewTextBoxColumn.ReadOnly = true;
			this.musteriidDataGridViewTextBoxColumn.Width = 125;
			// 
			// musteriadDataGridViewTextBoxColumn
			// 
			this.musteriadDataGridViewTextBoxColumn.DataPropertyName = "musteri_ad";
			this.musteriadDataGridViewTextBoxColumn.HeaderText = "musteri_ad";
			this.musteriadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.musteriadDataGridViewTextBoxColumn.Name = "musteriadDataGridViewTextBoxColumn";
			this.musteriadDataGridViewTextBoxColumn.Width = 125;
			// 
			// musterisoyadDataGridViewTextBoxColumn
			// 
			this.musterisoyadDataGridViewTextBoxColumn.DataPropertyName = "musteri_soyad";
			this.musterisoyadDataGridViewTextBoxColumn.HeaderText = "musteri_soyad";
			this.musterisoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.musterisoyadDataGridViewTextBoxColumn.Name = "musterisoyadDataGridViewTextBoxColumn";
			this.musterisoyadDataGridViewTextBoxColumn.Width = 125;
			// 
			// musteritelDataGridViewTextBoxColumn
			// 
			this.musteritelDataGridViewTextBoxColumn.DataPropertyName = "musteri_tel";
			this.musteritelDataGridViewTextBoxColumn.HeaderText = "musteri_tel";
			this.musteritelDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.musteritelDataGridViewTextBoxColumn.Name = "musteritelDataGridViewTextBoxColumn";
			this.musteritelDataGridViewTextBoxColumn.Width = 125;
			// 
			// musteriepostaDataGridViewTextBoxColumn
			// 
			this.musteriepostaDataGridViewTextBoxColumn.DataPropertyName = "musteri_eposta";
			this.musteriepostaDataGridViewTextBoxColumn.HeaderText = "musteri_eposta";
			this.musteriepostaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.musteriepostaDataGridViewTextBoxColumn.Name = "musteriepostaDataGridViewTextBoxColumn";
			this.musteriepostaDataGridViewTextBoxColumn.Width = 125;
			// 
			// musteriadresDataGridViewTextBoxColumn
			// 
			this.musteriadresDataGridViewTextBoxColumn.DataPropertyName = "musteri_adres";
			this.musteriadresDataGridViewTextBoxColumn.HeaderText = "musteri_adres";
			this.musteriadresDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.musteriadresDataGridViewTextBoxColumn.Name = "musteriadresDataGridViewTextBoxColumn";
			this.musteriadresDataGridViewTextBoxColumn.Width = 125;
			// 
			// musteriBindingSource
			// 
			this.musteriBindingSource.DataMember = "Musteri";
			this.musteriBindingSource.DataSource = this.projeDataSet6;
			// 
			// projeDataSet6
			// 
			this.projeDataSet6.DataSetName = "ProjeDataSet6";
			this.projeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 292);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 14;
			this.label2.Text = "Sayfa:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 257);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "Dosya Adı:";
			// 
			// musteriTableAdapter
			// 
			this.musteriTableAdapter.ClearBeforeFill = true;
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(950, 454);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form7";
			this.ShowIcon = false;
			this.Text = "İmport";
			this.Load += new System.EventHandler(this.Form7_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projeDataSet6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private ProjeDataSet6 projeDataSet6;
		private System.Windows.Forms.BindingSource musteriBindingSource;
		private ProjeDataSet6TableAdapters.MusteriTableAdapter musteriTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn musteriadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn musterisoyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn musteritelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn musteriepostaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn musteriadresDataGridViewTextBoxColumn;
	}
}