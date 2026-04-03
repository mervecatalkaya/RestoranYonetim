namespace PL_WindowsLayer
{
    partial class FormMasalar
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpMasaBilgileri = new System.Windows.Forms.GroupBox();
            this.btnDoluMasalar = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnBosMasa = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.txtKapasıte = new System.Windows.Forms.TextBox();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.lblMasaID = new System.Windows.Forms.Label();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpMasaBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMasaBilgileri
            // 
            this.grpMasaBilgileri.Controls.Add(this.btnDoluMasalar);
            this.grpMasaBilgileri.Controls.Add(this.btnSil);
            this.grpMasaBilgileri.Controls.Add(this.btnListele);
            this.grpMasaBilgileri.Controls.Add(this.btnBosMasa);
            this.grpMasaBilgileri.Controls.Add(this.btnGuncelle);
            this.grpMasaBilgileri.Controls.Add(this.btnEkle);
            this.grpMasaBilgileri.Controls.Add(this.lblDurum);
            this.grpMasaBilgileri.Controls.Add(this.lblKonum);
            this.grpMasaBilgileri.Controls.Add(this.lblKapasite);
            this.grpMasaBilgileri.Controls.Add(this.cmbDurum);
            this.grpMasaBilgileri.Controls.Add(this.cmbKonum);
            this.grpMasaBilgileri.Controls.Add(this.txtKapasıte);
            this.grpMasaBilgileri.Controls.Add(this.txtMasaNo);
            this.grpMasaBilgileri.Controls.Add(this.lblMasaNo);
            this.grpMasaBilgileri.Controls.Add(this.lblMasaID);
            this.grpMasaBilgileri.Controls.Add(this.txtMasaID);
            this.grpMasaBilgileri.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpMasaBilgileri.Location = new System.Drawing.Point(543, 0);
            this.grpMasaBilgileri.Name = "grpMasaBilgileri";
            this.grpMasaBilgileri.Size = new System.Drawing.Size(257, 450);
            this.grpMasaBilgileri.TabIndex = 0;
            this.grpMasaBilgileri.TabStop = false;
            this.grpMasaBilgileri.Text = "Masa Bilgileri";
            // 
            // btnDoluMasalar
            // 
            this.btnDoluMasalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDoluMasalar.Location = new System.Drawing.Point(153, 275);
            this.btnDoluMasalar.Name = "btnDoluMasalar";
            this.btnDoluMasalar.Size = new System.Drawing.Size(97, 37);
            this.btnDoluMasalar.TabIndex = 15;
            this.btnDoluMasalar.Text = "Dolu Masalar";
            this.btnDoluMasalar.UseVisualStyleBackColor = false;
            this.btnDoluMasalar.Click += new System.EventHandler(this.btnDoluMasalar_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(176, 237);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListele.Location = new System.Drawing.Point(63, 330);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(146, 28);
            this.btnListele.TabIndex = 13;
            this.btnListele.Text = "Tümünü Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnBosMasa
            // 
            this.btnBosMasa.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnBosMasa.Location = new System.Drawing.Point(20, 275);
            this.btnBosMasa.Name = "btnBosMasa";
            this.btnBosMasa.Size = new System.Drawing.Size(114, 37);
            this.btnBosMasa.TabIndex = 12;
            this.btnBosMasa.Text = "Boş masalar";
            this.btnBosMasa.UseVisualStyleBackColor = false;
            this.btnBosMasa.Click += new System.EventHandler(this.btnBosMasa_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(87, 237);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEkle.Location = new System.Drawing.Point(6, 237);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(26, 184);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(46, 16);
            this.lblDurum.TabIndex = 9;
            this.lblDurum.Text = "Durum";
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Location = new System.Drawing.Point(24, 144);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(48, 16);
            this.lblKonum.TabIndex = 8;
            this.lblKonum.Text = "Konum";
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Location = new System.Drawing.Point(17, 105);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(60, 16);
            this.lblKapasite.TabIndex = 7;
            this.lblKapasite.Text = "Kapasite";
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Boş",
            "Dolu"});
            this.cmbDurum.Location = new System.Drawing.Point(78, 176);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 24);
            this.cmbDurum.TabIndex = 6;
            // 
            // cmbKonum
            // 
            this.cmbKonum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Items.AddRange(new object[] {
            "İçeri",
            "Dışarı"});
            this.cmbKonum.Location = new System.Drawing.Point(78, 141);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(121, 24);
            this.cmbKonum.TabIndex = 5;
            // 
            // txtKapasıte
            // 
            this.txtKapasıte.Location = new System.Drawing.Point(77, 102);
            this.txtKapasıte.Name = "txtKapasıte";
            this.txtKapasıte.Size = new System.Drawing.Size(121, 22);
            this.txtKapasıte.TabIndex = 4;
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.Location = new System.Drawing.Point(77, 60);
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.Size = new System.Drawing.Size(121, 22);
            this.txtMasaNo.TabIndex = 3;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Location = new System.Drawing.Point(17, 63);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(62, 16);
            this.lblMasaNo.TabIndex = 2;
            this.lblMasaNo.Text = "Masa No";
            // 
            // lblMasaID
            // 
            this.lblMasaID.AutoSize = true;
            this.lblMasaID.Location = new System.Drawing.Point(17, 27);
            this.lblMasaID.Name = "lblMasaID";
            this.lblMasaID.Size = new System.Drawing.Size(54, 16);
            this.lblMasaID.TabIndex = 1;
            this.lblMasaID.Text = "MasaID";
            // 
            // txtMasaID
            // 
            this.txtMasaID.Location = new System.Drawing.Point(77, 27);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.ReadOnly = true;
            this.txtMasaID.Size = new System.Drawing.Size(121, 22);
            this.txtMasaID.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(543, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpMasaBilgileri);
            this.Name = "FormMasalar";
            this.Text = "FormMasalar";
            this.Load += new System.EventHandler(this.FormMasalar_Load);
            this.grpMasaBilgileri.ResumeLayout(false);
            this.grpMasaBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMasaBilgileri;
        private System.Windows.Forms.TextBox txtMasaID;
        private System.Windows.Forms.Label lblMasaID;
        private System.Windows.Forms.TextBox txtKapasıte;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnBosMasa;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDoluMasalar;
    }
}

