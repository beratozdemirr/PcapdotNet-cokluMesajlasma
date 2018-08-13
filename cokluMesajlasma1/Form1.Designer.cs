namespace cokluMesajlasma1
{
    partial class ilkEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ilkEkran));
            this.label1 = new System.Windows.Forms.Label();
            this.lstEthernet = new System.Windows.Forms.ListBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Mistral", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CİHAZLAR";
            // 
            // lstEthernet
            // 
            this.lstEthernet.FormattingEnabled = true;
            this.lstEthernet.Location = new System.Drawing.Point(12, 111);
            this.lstEthernet.Name = "lstEthernet";
            this.lstEthernet.Size = new System.Drawing.Size(817, 316);
            this.lstEthernet.TabIndex = 1;
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSec.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSec.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSec.Location = new System.Drawing.Point(593, 58);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(131, 47);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = false;
            // 
            // ilkEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lstEthernet);
            this.Controls.Add(this.label1);
            this.Name = "ilkEkran";
            this.Text = "ETHERNET SEÇİMİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEthernet;
        private System.Windows.Forms.Button btnSec;
    }
}

