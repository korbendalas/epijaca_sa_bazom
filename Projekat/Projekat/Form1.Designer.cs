namespace Projekat
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.unesiteBrojLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKreirajRacun = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.izaberiteProizvod = new System.Windows.Forms.Label();
            this.labelUkupnaCena = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.comboBoxVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.groupBoxDostava = new System.Windows.Forms.GroupBox();
            this.radioButtonAks = new System.Windows.Forms.RadioButton();
            this.radioButtonDhl = new System.Windows.Forms.RadioButton();
            this.radioButtonPostExpress = new System.Windows.Forms.RadioButton();
            this.radioButtonBex = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxDostava.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sacuvaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // unesiteBrojLabel
            // 
            this.unesiteBrojLabel.AutoSize = true;
            this.unesiteBrojLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unesiteBrojLabel.Location = new System.Drawing.Point(8, 13);
            this.unesiteBrojLabel.Name = "unesiteBrojLabel";
            this.unesiteBrojLabel.Size = new System.Drawing.Size(168, 18);
            this.unesiteBrojLabel.TabIndex = 3;
            this.unesiteBrojLabel.Text = "Izaberite vrstu proizvoda";
            this.unesiteBrojLabel.Click += new System.EventHandler(this.unesiteBrojLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Koliko zelite kilograma?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonKreirajRacun
            // 
            this.buttonKreirajRacun.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonKreirajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKreirajRacun.Location = new System.Drawing.Point(683, 440);
            this.buttonKreirajRacun.Name = "buttonKreirajRacun";
            this.buttonKreirajRacun.Size = new System.Drawing.Size(159, 42);
            this.buttonKreirajRacun.TabIndex = 14;
            this.buttonKreirajRacun.Text = "Kreiraj Racun";
            this.buttonKreirajRacun.UseVisualStyleBackColor = false;
            this.buttonKreirajRacun.Click += new System.EventHandler(this.buttonKreirajRacun_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 244);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(656, 173);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBox2.Location = new System.Drawing.Point(9, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(221, 28);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cena po kilogramu";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Coral;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(234, 439);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(216, 43);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Obrisi";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAll.Location = new System.Drawing.Point(461, 441);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(216, 42);
            this.buttonDeleteAll.TabIndex = 20;
            this.buttonDeleteAll.Text = "Obrisi sve";
            this.buttonDeleteAll.UseVisualStyleBackColor = false;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(11, 98);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(223, 28);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // izaberiteProizvod
            // 
            this.izaberiteProizvod.AutoSize = true;
            this.izaberiteProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izaberiteProizvod.Location = new System.Drawing.Point(8, 77);
            this.izaberiteProizvod.Name = "izaberiteProizvod";
            this.izaberiteProizvod.Size = new System.Drawing.Size(124, 18);
            this.izaberiteProizvod.TabIndex = 22;
            this.izaberiteProizvod.Text = "Izaberite proizvod";
            this.izaberiteProizvod.Click += new System.EventHandler(this.izaberiteProizvod_Click);
            // 
            // labelUkupnaCena
            // 
            this.labelUkupnaCena.AutoSize = true;
            this.labelUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUkupnaCena.Location = new System.Drawing.Point(708, 342);
            this.labelUkupnaCena.Name = "labelUkupnaCena";
            this.labelUkupnaCena.Size = new System.Drawing.Size(125, 24);
            this.labelUkupnaCena.TabIndex = 26;
            this.labelUkupnaCena.Text = "Ukupna Cena";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(700, 275);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(133, 48);
            this.richTextBox2.TabIndex = 27;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(700, 369);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(133, 48);
            this.richTextBox3.TabIndex = 28;
            this.richTextBox3.Text = "";
            // 
            // comboBoxVrstaProizvoda
            // 
            this.comboBoxVrstaProizvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVrstaProizvoda.FormattingEnabled = true;
            this.comboBoxVrstaProizvoda.Items.AddRange(new object[] {
            "Voce",
            "Povrce"});
            this.comboBoxVrstaProizvoda.Location = new System.Drawing.Point(11, 34);
            this.comboBoxVrstaProizvoda.Name = "comboBoxVrstaProizvoda";
            this.comboBoxVrstaProizvoda.Size = new System.Drawing.Size(220, 28);
            this.comboBoxVrstaProizvoda.TabIndex = 29;
            this.comboBoxVrstaProizvoda.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaProizvoda_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(31, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(30, 16);
            this.labelName.TabIndex = 31;
            this.labelName.Text = "Ime";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(28, 73);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(57, 16);
            this.labelLastName.TabIndex = 32;
            this.labelLastName.Text = "Prezime";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(27, 115);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(54, 18);
            this.labelAddress.TabIndex = 33;
            this.labelAddress.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Trenutno ste odabrali : ";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(91, 28);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(177, 26);
            this.textBoxIme.TabIndex = 40;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBoxIme_TextChanged);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(92, 70);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(176, 26);
            this.textBoxPrezime.TabIndex = 41;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.textBoxPrezime_TextChanged);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(91, 112);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(177, 26);
            this.textBoxAdresa.TabIndex = 42;
            this.textBoxAdresa.TextChanged += new System.EventHandler(this.textBoxAdresa_TextChanged);
            // 
            // groupBoxDostava
            // 
            this.groupBoxDostava.Controls.Add(this.radioButtonAks);
            this.groupBoxDostava.Controls.Add(this.radioButtonDhl);
            this.groupBoxDostava.Controls.Add(this.radioButtonPostExpress);
            this.groupBoxDostava.Controls.Add(this.radioButtonBex);
            this.groupBoxDostava.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDostava.Location = new System.Drawing.Point(669, 47);
            this.groupBoxDostava.Name = "groupBoxDostava";
            this.groupBoxDostava.Size = new System.Drawing.Size(173, 159);
            this.groupBoxDostava.TabIndex = 43;
            this.groupBoxDostava.TabStop = false;
            this.groupBoxDostava.Text = "Dostava";
            // 
            // radioButtonAks
            // 
            this.radioButtonAks.AutoSize = true;
            this.radioButtonAks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAks.Location = new System.Drawing.Point(7, 102);
            this.radioButtonAks.Name = "radioButtonAks";
            this.radioButtonAks.Size = new System.Drawing.Size(65, 28);
            this.radioButtonAks.TabIndex = 3;
            this.radioButtonAks.TabStop = true;
            this.radioButtonAks.Text = "AKS";
            this.radioButtonAks.UseVisualStyleBackColor = true;
            this.radioButtonAks.CheckedChanged += new System.EventHandler(this.radioButtonAks_CheckedChanged);
            // 
            // radioButtonDhl
            // 
            this.radioButtonDhl.AutoSize = true;
            this.radioButtonDhl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDhl.Location = new System.Drawing.Point(7, 78);
            this.radioButtonDhl.Name = "radioButtonDhl";
            this.radioButtonDhl.Size = new System.Drawing.Size(65, 28);
            this.radioButtonDhl.TabIndex = 2;
            this.radioButtonDhl.TabStop = true;
            this.radioButtonDhl.Text = "DHL";
            this.radioButtonDhl.UseVisualStyleBackColor = true;
            this.radioButtonDhl.CheckedChanged += new System.EventHandler(this.radioButtonDhl_CheckedChanged);
            // 
            // radioButtonPostExpress
            // 
            this.radioButtonPostExpress.AutoSize = true;
            this.radioButtonPostExpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPostExpress.Location = new System.Drawing.Point(6, 55);
            this.radioButtonPostExpress.Name = "radioButtonPostExpress";
            this.radioButtonPostExpress.Size = new System.Drawing.Size(138, 28);
            this.radioButtonPostExpress.TabIndex = 1;
            this.radioButtonPostExpress.TabStop = true;
            this.radioButtonPostExpress.Text = "Post Express";
            this.radioButtonPostExpress.UseVisualStyleBackColor = true;
            this.radioButtonPostExpress.CheckedChanged += new System.EventHandler(this.radioButtonPostExpress_CheckedChanged);
            // 
            // radioButtonBex
            // 
            this.radioButtonBex.AutoSize = true;
            this.radioButtonBex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBex.Location = new System.Drawing.Point(5, 27);
            this.radioButtonBex.Name = "radioButtonBex";
            this.radioButtonBex.Size = new System.Drawing.Size(61, 28);
            this.radioButtonBex.TabIndex = 0;
            this.radioButtonBex.TabStop = true;
            this.radioButtonBex.Text = "Bex";
            this.radioButtonBex.UseVisualStyleBackColor = true;
            this.radioButtonBex.CheckedChanged += new System.EventHandler(this.radioButtonBex_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.editToolStripMenuItem.Text = "Tools";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxAdresa);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.textBoxPrezime);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.textBoxIme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(269, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 179);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnicki podaci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.unesiteBrojLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBoxVrstaProizvoda);
            this.groupBox2.Controls.Add(this.izaberiteProizvod);
            this.groupBox2.Location = new System.Drawing.Point(16, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 193);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(854, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDostava);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.labelUkupnaCena);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonKreirajRacun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ePijaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDostava.ResumeLayout(false);
            this.groupBoxDostava.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label unesiteBrojLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKreirajRacun;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label izaberiteProizvod;
        private System.Windows.Forms.Label labelUkupnaCena;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ComboBox comboBoxVrstaProizvoda;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.GroupBox groupBoxDostava;
        private System.Windows.Forms.RadioButton radioButtonAks;
        private System.Windows.Forms.RadioButton radioButtonDhl;
        private System.Windows.Forms.RadioButton radioButtonPostExpress;
        private System.Windows.Forms.RadioButton radioButtonBex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

