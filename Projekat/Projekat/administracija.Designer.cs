namespace Projekat
{
    partial class administracija
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
			this.dataGridViewPorudzbine = new System.Windows.Forms.DataGridView();
			this.buttonIzadji = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.pijacadbDataSet1 = new Projekat.pijacadbDataSet1();
			this.racunTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.racunTableTableAdapter = new Projekat.pijacadbDataSet1TableAdapters.racunTableTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dostavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.artikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPorudzbine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pijacadbDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.racunTableBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridViewPorudzbine);
			this.groupBox1.Location = new System.Drawing.Point(13, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1096, 307);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Porudzbine";
			// 
			// dataGridViewPorudzbine
			// 
			this.dataGridViewPorudzbine.AllowUserToOrderColumns = true;
			this.dataGridViewPorudzbine.AutoGenerateColumns = false;
			this.dataGridViewPorudzbine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPorudzbine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.dostavljacDataGridViewTextBoxColumn,
            this.artikliDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
			this.dataGridViewPorudzbine.DataSource = this.racunTableBindingSource;
			this.dataGridViewPorudzbine.Location = new System.Drawing.Point(0, 19);
			this.dataGridViewPorudzbine.Name = "dataGridViewPorudzbine";
			this.dataGridViewPorudzbine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPorudzbine.Size = new System.Drawing.Size(860, 298);
			this.dataGridViewPorudzbine.TabIndex = 0;
			this.dataGridViewPorudzbine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPorudzbine_CellContentClick);
			this.dataGridViewPorudzbine.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPorudzbine_DataError);
			// 
			// buttonIzadji
			// 
			this.buttonIzadji.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIzadji.Location = new System.Drawing.Point(299, 347);
			this.buttonIzadji.Name = "buttonIzadji";
			this.buttonIzadji.Size = new System.Drawing.Size(170, 47);
			this.buttonIzadji.TabIndex = 3;
			this.buttonIzadji.Text = "IZADJI";
			this.buttonIzadji.UseVisualStyleBackColor = false;
			this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.Salmon;
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Location = new System.Drawing.Point(35, 347);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(171, 49);
			this.buttonDelete.TabIndex = 4;
			this.buttonDelete.Text = "OBRISI";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
			// 
			// pijacadbDataSet1
			// 
			this.pijacadbDataSet1.DataSetName = "pijacadbDataSet1";
			this.pijacadbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// racunTableBindingSource
			// 
			this.racunTableBindingSource.DataMember = "racunTable";
			this.racunTableBindingSource.DataSource = this.pijacadbDataSet1;
			// 
			// racunTableTableAdapter
			// 
			this.racunTableTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// imeDataGridViewTextBoxColumn
			// 
			this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
			this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
			this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
			// 
			// prezimeDataGridViewTextBoxColumn
			// 
			this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
			this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
			this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
			// 
			// adresaDataGridViewTextBoxColumn
			// 
			this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
			this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
			this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
			// 
			// dostavljacDataGridViewTextBoxColumn
			// 
			this.dostavljacDataGridViewTextBoxColumn.DataPropertyName = "dostavljac";
			this.dostavljacDataGridViewTextBoxColumn.HeaderText = "dostavljac";
			this.dostavljacDataGridViewTextBoxColumn.Name = "dostavljacDataGridViewTextBoxColumn";
			// 
			// artikliDataGridViewTextBoxColumn
			// 
			this.artikliDataGridViewTextBoxColumn.DataPropertyName = "artikli";
			this.artikliDataGridViewTextBoxColumn.HeaderText = "artikli";
			this.artikliDataGridViewTextBoxColumn.Name = "artikliDataGridViewTextBoxColumn";
			// 
			// cenaDataGridViewTextBoxColumn
			// 
			this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
			this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
			this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
			// 
			// datumDataGridViewTextBoxColumn
			// 
			this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
			this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
			this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
			// 
			// administracija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.ClientSize = new System.Drawing.Size(876, 413);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonIzadji);
			this.Controls.Add(this.groupBox1);
			this.Name = "administracija";
			this.Text = "Administracija";
			this.Load += new System.EventHandler(this.administracija_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPorudzbine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pijacadbDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.racunTableBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPorudzbine;
        private System.Windows.Forms.Button buttonIzadji;
        private System.Windows.Forms.Button buttonDelete;
		private pijacadbDataSet1 pijacadbDataSet1;
		private System.Windows.Forms.BindingSource racunTableBindingSource;
		private pijacadbDataSet1TableAdapters.racunTableTableAdapter racunTableTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dostavljacDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn artikliDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
	}
}