namespace Veri_Tabanli_Parti_Secim_Grafik_Istatistik
{
    partial class FrmOyGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlceAd = new System.Windows.Forms.TextBox();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOyGirisi = new System.Windows.Forms.Button();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE AD:";
            // 
            // txtIlceAd
            // 
            this.txtIlceAd.Location = new System.Drawing.Point(126, 54);
            this.txtIlceAd.Name = "txtIlceAd";
            this.txtIlceAd.Size = new System.Drawing.Size(394, 29);
            this.txtIlceAd.TabIndex = 1;
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(126, 252);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(394, 29);
            this.txtDP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "D PARTİ:";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(126, 217);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(394, 29);
            this.txtCP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "C PARTİ:";
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(126, 182);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(394, 29);
            this.txtBP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "B PARTİ:";
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(126, 147);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(394, 29);
            this.txtAP.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "A PARTİ:";
            // 
            // txtEP
            // 
            this.txtEP.Location = new System.Drawing.Point(126, 287);
            this.txtEP.Name = "txtEP";
            this.txtEP.Size = new System.Drawing.Size(394, 29);
            this.txtEP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ:";
            // 
            // btnOyGirisi
            // 
            this.btnOyGirisi.Location = new System.Drawing.Point(126, 322);
            this.btnOyGirisi.Name = "btnOyGirisi";
            this.btnOyGirisi.Size = new System.Drawing.Size(394, 39);
            this.btnOyGirisi.TabIndex = 12;
            this.btnOyGirisi.Text = "OY GİRİŞİ YAP";
            this.btnOyGirisi.UseVisualStyleBackColor = true;
            this.btnOyGirisi.Click += new System.EventHandler(this.btnOyGirisi_Click);
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(127, 367);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(199, 39);
            this.btnGrafik.TabIndex = 14;
            this.btnGrafik.Text = "GRAFİKLER";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(332, 367);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(188, 39);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "ÇIKIŞ YAP";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // FrmOyGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(591, 480);
            this.Controls.Add(this.btnGrafik);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOyGirisi);
            this.Controls.Add(this.txtEP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIlceAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOyGiris";
            this.Text = "VTGS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlceAd;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOyGirisi;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnCikis;
    }
}

