namespace PL_WindowsLayer
{
    partial class FormAnaSayfa
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
            this.btnMasalar = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasalar
            // 
            this.btnMasalar.BackColor = System.Drawing.Color.Maroon;
            this.btnMasalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMasalar.Location = new System.Drawing.Point(73, 201);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(160, 81);
            this.btnMasalar.TabIndex = 0;
            this.btnMasalar.Text = "Masa Yönetimi";
            this.btnMasalar.UseVisualStyleBackColor = false;
            this.btnMasalar.Click += new System.EventHandler(this.btnMasalar_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.Maroon;
            this.btnUrunler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunler.Location = new System.Drawing.Point(326, 201);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(162, 81);
            this.btnUrunler.TabIndex = 1;
            this.btnUrunler.Text = "Ürün Yönetimi";
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.BackColor = System.Drawing.Color.Maroon;
            this.btnSiparisler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSiparisler.Location = new System.Drawing.Point(585, 201);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(164, 81);
            this.btnSiparisler.TabIndex = 2;
            this.btnSiparisler.Text = "Sipariş ve Kasa";
            this.btnSiparisler.UseVisualStyleBackColor = false;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCikis.Location = new System.Drawing.Point(674, 375);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 32);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PL_WindowsLayer.Properties.Resources.restoran;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSiparisler);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.btnMasalar);
            this.Name = "FormAnaSayfa";
            this.Text = "FormAnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasalar;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.Button btnCikis;
    }
}