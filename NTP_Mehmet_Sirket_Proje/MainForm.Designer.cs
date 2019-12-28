namespace NTP_Mehmet_Sirket_Proje
{
    partial class MainForm
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
            this.SatisBtn = new System.Windows.Forms.Button();
            this.Musteribtn = new System.Windows.Forms.Button();
            this.Yoneticibtn = new System.Windows.Forms.Button();
            this.YapilanSatisbtn = new System.Windows.Forms.Button();
            this.UrunIslembtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SatisBtn
            // 
            this.SatisBtn.Location = new System.Drawing.Point(113, 60);
            this.SatisBtn.Name = "SatisBtn";
            this.SatisBtn.Size = new System.Drawing.Size(124, 54);
            this.SatisBtn.TabIndex = 0;
            this.SatisBtn.Text = "Satış Ekranı";
            this.SatisBtn.UseVisualStyleBackColor = true;
            this.SatisBtn.Click += new System.EventHandler(this.SatisBtn_Click);
            // 
            // Musteribtn
            // 
            this.Musteribtn.Location = new System.Drawing.Point(113, 141);
            this.Musteribtn.Name = "Musteribtn";
            this.Musteribtn.Size = new System.Drawing.Size(124, 54);
            this.Musteribtn.TabIndex = 1;
            this.Musteribtn.Text = "Müşteri İşlemleri Ekranı";
            this.Musteribtn.UseVisualStyleBackColor = true;
            this.Musteribtn.Click += new System.EventHandler(this.Musteribtn_Click);
            // 
            // Yoneticibtn
            // 
            this.Yoneticibtn.Location = new System.Drawing.Point(113, 307);
            this.Yoneticibtn.Name = "Yoneticibtn";
            this.Yoneticibtn.Size = new System.Drawing.Size(124, 54);
            this.Yoneticibtn.TabIndex = 2;
            this.Yoneticibtn.Text = "Yönetici Ekranı";
            this.Yoneticibtn.UseVisualStyleBackColor = true;
            this.Yoneticibtn.Click += new System.EventHandler(this.Yoneticibtn_Click);
            // 
            // YapilanSatisbtn
            // 
            this.YapilanSatisbtn.Location = new System.Drawing.Point(113, 226);
            this.YapilanSatisbtn.Name = "YapilanSatisbtn";
            this.YapilanSatisbtn.Size = new System.Drawing.Size(124, 54);
            this.YapilanSatisbtn.TabIndex = 0;
            this.YapilanSatisbtn.Text = "Yapılan Satışları Görüntüle";
            this.YapilanSatisbtn.UseVisualStyleBackColor = true;
            this.YapilanSatisbtn.Click += new System.EventHandler(this.YapilanSatisbtn_Click);
            // 
            // UrunIslembtn
            // 
            this.UrunIslembtn.Location = new System.Drawing.Point(281, 71);
            this.UrunIslembtn.Name = "UrunIslembtn";
            this.UrunIslembtn.Size = new System.Drawing.Size(124, 54);
            this.UrunIslembtn.TabIndex = 3;
            this.UrunIslembtn.Text = "Ürün İşlemleri";
            this.UrunIslembtn.UseVisualStyleBackColor = true;
            this.UrunIslembtn.Click += new System.EventHandler(this.UrunIslembtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 373);
            this.Controls.Add(this.UrunIslembtn);
            this.Controls.Add(this.Yoneticibtn);
            this.Controls.Add(this.Musteribtn);
            this.Controls.Add(this.YapilanSatisbtn);
            this.Controls.Add(this.SatisBtn);
            this.Name = "MainForm";
            this.Text = "Yönetim Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SatisBtn;
        private System.Windows.Forms.Button Musteribtn;
        private System.Windows.Forms.Button Yoneticibtn;
        private System.Windows.Forms.Button YapilanSatisbtn;
        private System.Windows.Forms.Button UrunIslembtn;
    }
}

