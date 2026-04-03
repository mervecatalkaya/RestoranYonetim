namespace PL_WindowsLayer
{
    partial class FormUrunler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpBoxUrun = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBoxUrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // grpBoxUrun
            // 
            this.grpBoxUrun.Controls.Add(this.btnSil);
            this.grpBoxUrun.Controls.Add(this.btnTumunuListele);
            this.grpBoxUrun.Controls.Add(this.btnGüncelle);
            this.grpBoxUrun.Controls.Add(this.btnEkle);
            this.grpBoxUrun.Controls.Add(this.lblKategori);
            this.grpBoxUrun.Controls.Add(this.lblStok);
            this.grpBoxUrun.Controls.Add(this.lblFiyat);
            this.grpBoxUrun.Controls.Add(this.lblUrunAdi);
            this.grpBoxUrun.Controls.Add(this.lblUrunID);
            this.grpBoxUrun.Controls.Add(this.chkDurum);
            this.grpBoxUrun.Controls.Add(this.cmbKategori);
            this.grpBoxUrun.Controls.Add(this.txtStok);
            this.grpBoxUrun.Controls.Add(this.txtUrunAdi);
            this.grpBoxUrun.Controls.Add(this.txtFiyat);
            this.grpBoxUrun.Controls.Add(this.txtUrunID);
            this.grpBoxUrun.Location = new System.Drawing.Point(468, 0);
            this.grpBoxUrun.Name = "grpBoxUrun";
            this.grpBoxUrun.Size = new System.Drawing.Size(320, 438);
            this.grpBoxUrun.TabIndex = 1;
            this.grpBoxUrun.TabStop = false;
            this.grpBoxUrun.Text = "Ürün Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(157, 329);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTumunuListele.Location = new System.Drawing.Point(157, 385);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(123, 29);
            this.btnTumunuListele.TabIndex = 13;
            this.btnTumunuListele.Text = "Tümünü Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = false;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGüncelle.Location = new System.Drawing.Point(43, 385);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(84, 29);
            this.btnGüncelle.TabIndex = 12;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEkle.Location = new System.Drawing.Point(43, 329);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(35, 144);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(57, 16);
            this.lblKategori.TabIndex = 10;
            this.lblKategori.Text = "Kategori";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(40, 246);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(34, 16);
            this.lblStok.TabIndex = 9;
            this.lblStok.Text = "Stok";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(40, 194);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(36, 16);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(34, 86);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(58, 16);
            this.lblUrunAdi.TabIndex = 7;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(40, 43);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(51, 16);
            this.lblUrunID.TabIndex = 6;
            this.lblUrunID.Text = "Ürün ID";
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(211, 280);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(94, 20);
            this.chkDurum.TabIndex = 5;
            this.chkDurum.Text = "Satışta mı?";
            this.chkDurum.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Yemek",
            "Tatlı",
            "İçecek"});
            this.cmbKategori.Location = new System.Drawing.Point(108, 136);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(111, 24);
            this.cmbKategori.TabIndex = 4;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(108, 240);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(111, 22);
            this.txtStok.TabIndex = 3;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(108, 83);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(111, 22);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(108, 188);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(111, 22);
            this.txtFiyat.TabIndex = 1;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(108, 43);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(111, 22);
            this.txtUrunID.TabIndex = 0;
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxUrun);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUrunler";
            this.Text = "FormUrunler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBoxUrun.ResumeLayout(false);
            this.grpBoxUrun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpBoxUrun;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTumunuListele;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}