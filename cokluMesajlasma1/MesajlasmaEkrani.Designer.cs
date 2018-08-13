namespace cokluMesajlasma1
{
    partial class MesajlasmaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesajlasmaEkrani));
            this.PanelMesajlasma = new System.Windows.Forms.Panel();
            this.richTextMesajlar = new System.Windows.Forms.RichTextBox();
            this.textBoxMesaj = new System.Windows.Forms.RichTextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.PanelKullaniciAdi = new System.Windows.Forms.Panel();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.PanelMesajlasma.SuspendLayout();
            this.PanelKullaniciAdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMesajlasma
            // 
            this.PanelMesajlasma.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelMesajlasma.Controls.Add(this.btnGonder);
            this.PanelMesajlasma.Controls.Add(this.textBoxMesaj);
            this.PanelMesajlasma.Controls.Add(this.richTextMesajlar);
            this.PanelMesajlasma.Location = new System.Drawing.Point(59, 45);
            this.PanelMesajlasma.Name = "PanelMesajlasma";
            this.PanelMesajlasma.Size = new System.Drawing.Size(587, 377);
            this.PanelMesajlasma.TabIndex = 0;
            // 
            // richTextMesajlar
            // 
            this.richTextMesajlar.Location = new System.Drawing.Point(13, 13);
            this.richTextMesajlar.Name = "richTextMesajlar";
            this.richTextMesajlar.Size = new System.Drawing.Size(510, 268);
            this.richTextMesajlar.TabIndex = 0;
            this.richTextMesajlar.Text = "";
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.Location = new System.Drawing.Point(42, 287);
            this.textBoxMesaj.Name = "textBoxMesaj";
            this.textBoxMesaj.Size = new System.Drawing.Size(354, 64);
            this.textBoxMesaj.TabIndex = 1;
            this.textBoxMesaj.Text = "";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonder.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnGonder.Location = new System.Drawing.Point(421, 300);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(86, 51);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = false;
            // 
            // PanelKullaniciAdi
            // 
            this.PanelKullaniciAdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelKullaniciAdi.BackgroundImage")));
            this.PanelKullaniciAdi.Controls.Add(this.btnGiris);
            this.PanelKullaniciAdi.Controls.Add(this.textBoxKullaniciAdi);
            this.PanelKullaniciAdi.Controls.Add(this.lblKullanici);
            this.PanelKullaniciAdi.Location = new System.Drawing.Point(724, 45);
            this.PanelKullaniciAdi.Name = "PanelKullaniciAdi";
            this.PanelKullaniciAdi.Size = new System.Drawing.Size(368, 377);
            this.PanelKullaniciAdi.TabIndex = 1;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullanici.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblKullanici.Location = new System.Drawing.Point(87, 38);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(238, 25);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı Adınızı Giriniz ";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(92, 91);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(233, 20);
            this.textBoxKullaniciAdi.TabIndex = 1;
            this.textBoxKullaniciAdi.TextChanged += new System.EventHandler(this.textBoxKullaniciAdi_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnGiris.Location = new System.Drawing.Point(140, 206);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(119, 48);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            // 
            // MesajlasmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(836, 494);
            this.Controls.Add(this.PanelKullaniciAdi);
            this.Controls.Add(this.PanelMesajlasma);
            this.Name = "MesajlasmaEkrani";
            this.Text = "MesajlasmaEkrani";
            this.PanelMesajlasma.ResumeLayout(false);
            this.PanelKullaniciAdi.ResumeLayout(false);
            this.PanelKullaniciAdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMesajlasma;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.RichTextBox textBoxMesaj;
        private System.Windows.Forms.RichTextBox richTextMesajlar;
        private System.Windows.Forms.Panel PanelKullaniciAdi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Label lblKullanici;
    }
}