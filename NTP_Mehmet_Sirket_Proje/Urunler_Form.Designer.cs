namespace NTP_Mehmet_Sirket_Proje
{
    partial class Urunler_Form
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
            this.Ekle_button = new System.Windows.Forms.Button();
            this.urun_kodu_textbox = new System.Windows.Forms.TextBox();
            this.urun_adi_textbox = new System.Windows.Forms.TextBox();
            this.urun_stokMik_textbox = new System.Windows.Forms.TextBox();
            this.urun_fiyat_textbox = new System.Windows.Forms.TextBox();
            this.urunKodulbl = new System.Windows.Forms.Label();
            this.urunAdilbl = new System.Windows.Forms.Label();
            this.urunStoklbl = new System.Windows.Forms.Label();
            this.urunFiyatlbl = new System.Windows.Forms.Label();
            this.urunSillbl = new System.Windows.Forms.Label();
            this.urunSiltextbox = new System.Windows.Forms.TextBox();
            this.Urun_Sil_Button = new System.Windows.Forms.Button();
            this.yeniUrunKodulbl = new System.Windows.Forms.Label();
            this.yeniUrunAdilbl = new System.Windows.Forms.Label();
            this.yeniUrunStoklbl = new System.Windows.Forms.Label();
            this.yeniUrunFiyat = new System.Windows.Forms.Label();
            this.yeniUrunKoduText = new System.Windows.Forms.TextBox();
            this.yeniUrunAdiTextb = new System.Windows.Forms.TextBox();
            this.yeniUrunStokMikText = new System.Windows.Forms.TextBox();
            this.yeniUrunFiyatText = new System.Windows.Forms.TextBox();
            this.GuncelleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ekle_button
            // 
            this.Ekle_button.Location = new System.Drawing.Point(143, 174);
            this.Ekle_button.Name = "Ekle_button";
            this.Ekle_button.Size = new System.Drawing.Size(100, 23);
            this.Ekle_button.TabIndex = 0;
            this.Ekle_button.Text = "ÜRÜN KAYIT";
            this.Ekle_button.UseVisualStyleBackColor = true;
            this.Ekle_button.Click += new System.EventHandler(this.Ekle_button_Click);
            // 
            // urun_kodu_textbox
            // 
            this.urun_kodu_textbox.Location = new System.Drawing.Point(143, 43);
            this.urun_kodu_textbox.Name = "urun_kodu_textbox";
            this.urun_kodu_textbox.Size = new System.Drawing.Size(100, 20);
            this.urun_kodu_textbox.TabIndex = 1;
            // 
            // urun_adi_textbox
            // 
            this.urun_adi_textbox.Location = new System.Drawing.Point(143, 80);
            this.urun_adi_textbox.Name = "urun_adi_textbox";
            this.urun_adi_textbox.Size = new System.Drawing.Size(100, 20);
            this.urun_adi_textbox.TabIndex = 2;
            // 
            // urun_stokMik_textbox
            // 
            this.urun_stokMik_textbox.Location = new System.Drawing.Point(143, 106);
            this.urun_stokMik_textbox.Name = "urun_stokMik_textbox";
            this.urun_stokMik_textbox.Size = new System.Drawing.Size(100, 20);
            this.urun_stokMik_textbox.TabIndex = 3;
            // 
            // urun_fiyat_textbox
            // 
            this.urun_fiyat_textbox.Location = new System.Drawing.Point(143, 132);
            this.urun_fiyat_textbox.Name = "urun_fiyat_textbox";
            this.urun_fiyat_textbox.Size = new System.Drawing.Size(100, 20);
            this.urun_fiyat_textbox.TabIndex = 4;
            // 
            // urunKodulbl
            // 
            this.urunKodulbl.AutoSize = true;
            this.urunKodulbl.Location = new System.Drawing.Point(35, 50);
            this.urunKodulbl.Name = "urunKodulbl";
            this.urunKodulbl.Size = new System.Drawing.Size(61, 13);
            this.urunKodulbl.TabIndex = 5;
            this.urunKodulbl.Text = "Urun Kodu:";
            // 
            // urunAdilbl
            // 
            this.urunAdilbl.AutoSize = true;
            this.urunAdilbl.Location = new System.Drawing.Point(35, 87);
            this.urunAdilbl.Name = "urunAdilbl";
            this.urunAdilbl.Size = new System.Drawing.Size(51, 13);
            this.urunAdilbl.TabIndex = 6;
            this.urunAdilbl.Text = "Urun Adı:";
            // 
            // urunStoklbl
            // 
            this.urunStoklbl.AutoSize = true;
            this.urunStoklbl.Location = new System.Drawing.Point(35, 113);
            this.urunStoklbl.Name = "urunStoklbl";
            this.urunStoklbl.Size = new System.Drawing.Size(92, 13);
            this.urunStoklbl.TabIndex = 7;
            this.urunStoklbl.Text = "Urun Stok Miktarı:";
            // 
            // urunFiyatlbl
            // 
            this.urunFiyatlbl.AutoSize = true;
            this.urunFiyatlbl.Location = new System.Drawing.Point(62, 139);
            this.urunFiyatlbl.Name = "urunFiyatlbl";
            this.urunFiyatlbl.Size = new System.Drawing.Size(60, 13);
            this.urunFiyatlbl.TabIndex = 8;
            this.urunFiyatlbl.Text = "Urun Fiyatı:";
            // 
            // urunSillbl
            // 
            this.urunSillbl.AutoSize = true;
            this.urunSillbl.Location = new System.Drawing.Point(278, 43);
            this.urunSillbl.Name = "urunSillbl";
            this.urunSillbl.Size = new System.Drawing.Size(107, 13);
            this.urunSillbl.TabIndex = 9;
            this.urunSillbl.Text = "Silinecek Ürün Kodu:";
            // 
            // urunSiltextbox
            // 
            this.urunSiltextbox.Location = new System.Drawing.Point(391, 40);
            this.urunSiltextbox.Name = "urunSiltextbox";
            this.urunSiltextbox.Size = new System.Drawing.Size(100, 20);
            this.urunSiltextbox.TabIndex = 10;
            // 
            // Urun_Sil_Button
            // 
            this.Urun_Sil_Button.Location = new System.Drawing.Point(391, 66);
            this.Urun_Sil_Button.Name = "Urun_Sil_Button";
            this.Urun_Sil_Button.Size = new System.Drawing.Size(100, 23);
            this.Urun_Sil_Button.TabIndex = 11;
            this.Urun_Sil_Button.Text = "ÜRÜN SİL";
            this.Urun_Sil_Button.UseVisualStyleBackColor = true;
            // 
            // yeniUrunKodulbl
            // 
            this.yeniUrunKodulbl.AutoSize = true;
            this.yeniUrunKodulbl.Location = new System.Drawing.Point(388, 192);
            this.yeniUrunKodulbl.Name = "yeniUrunKodulbl";
            this.yeniUrunKodulbl.Size = new System.Drawing.Size(61, 13);
            this.yeniUrunKodulbl.TabIndex = 13;
            this.yeniUrunKodulbl.Text = "Ürün Kodu:";
            // 
            // yeniUrunAdilbl
            // 
            this.yeniUrunAdilbl.AutoSize = true;
            this.yeniUrunAdilbl.Location = new System.Drawing.Point(388, 220);
            this.yeniUrunAdilbl.Name = "yeniUrunAdilbl";
            this.yeniUrunAdilbl.Size = new System.Drawing.Size(75, 13);
            this.yeniUrunAdilbl.TabIndex = 14;
            this.yeniUrunAdilbl.Text = "Yeni Ürün Adı:";
            // 
            // yeniUrunStoklbl
            // 
            this.yeniUrunStoklbl.AutoSize = true;
            this.yeniUrunStoklbl.Location = new System.Drawing.Point(388, 248);
            this.yeniUrunStoklbl.Name = "yeniUrunStoklbl";
            this.yeniUrunStoklbl.Size = new System.Drawing.Size(113, 13);
            this.yeniUrunStoklbl.TabIndex = 15;
            this.yeniUrunStoklbl.Text = "Yeni Ürün Stok Miktaı:";
            // 
            // yeniUrunFiyat
            // 
            this.yeniUrunFiyat.AutoSize = true;
            this.yeniUrunFiyat.Location = new System.Drawing.Point(388, 276);
            this.yeniUrunFiyat.Name = "yeniUrunFiyat";
            this.yeniUrunFiyat.Size = new System.Drawing.Size(84, 13);
            this.yeniUrunFiyat.TabIndex = 16;
            this.yeniUrunFiyat.Text = "Yeni Urun Fiyatı:";
            // 
            // yeniUrunKoduText
            // 
            this.yeniUrunKoduText.Location = new System.Drawing.Point(555, 189);
            this.yeniUrunKoduText.Name = "yeniUrunKoduText";
            this.yeniUrunKoduText.Size = new System.Drawing.Size(100, 20);
            this.yeniUrunKoduText.TabIndex = 18;
            // 
            // yeniUrunAdiTextb
            // 
            this.yeniUrunAdiTextb.Location = new System.Drawing.Point(555, 221);
            this.yeniUrunAdiTextb.Name = "yeniUrunAdiTextb";
            this.yeniUrunAdiTextb.Size = new System.Drawing.Size(100, 20);
            this.yeniUrunAdiTextb.TabIndex = 19;
            // 
            // yeniUrunStokMikText
            // 
            this.yeniUrunStokMikText.Location = new System.Drawing.Point(555, 253);
            this.yeniUrunStokMikText.Name = "yeniUrunStokMikText";
            this.yeniUrunStokMikText.Size = new System.Drawing.Size(100, 20);
            this.yeniUrunStokMikText.TabIndex = 20;
            // 
            // yeniUrunFiyatText
            // 
            this.yeniUrunFiyatText.Location = new System.Drawing.Point(555, 285);
            this.yeniUrunFiyatText.Name = "yeniUrunFiyatText";
            this.yeniUrunFiyatText.Size = new System.Drawing.Size(100, 20);
            this.yeniUrunFiyatText.TabIndex = 21;
            // 
            // GuncelleButton
            // 
            this.GuncelleButton.Location = new System.Drawing.Point(555, 322);
            this.GuncelleButton.Name = "GuncelleButton";
            this.GuncelleButton.Size = new System.Drawing.Size(100, 23);
            this.GuncelleButton.TabIndex = 22;
            this.GuncelleButton.Text = "Güncelle";
            this.GuncelleButton.UseVisualStyleBackColor = true;
            this.GuncelleButton.Click += new System.EventHandler(this.GuncelleButton_Click);
            // 
            // Urunler_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuncelleButton);
            this.Controls.Add(this.yeniUrunFiyatText);
            this.Controls.Add(this.yeniUrunStokMikText);
            this.Controls.Add(this.yeniUrunAdiTextb);
            this.Controls.Add(this.yeniUrunKoduText);
            this.Controls.Add(this.yeniUrunFiyat);
            this.Controls.Add(this.yeniUrunStoklbl);
            this.Controls.Add(this.yeniUrunAdilbl);
            this.Controls.Add(this.yeniUrunKodulbl);
            this.Controls.Add(this.Urun_Sil_Button);
            this.Controls.Add(this.urunSiltextbox);
            this.Controls.Add(this.urunSillbl);
            this.Controls.Add(this.urunFiyatlbl);
            this.Controls.Add(this.urunStoklbl);
            this.Controls.Add(this.urunAdilbl);
            this.Controls.Add(this.urunKodulbl);
            this.Controls.Add(this.urun_fiyat_textbox);
            this.Controls.Add(this.urun_stokMik_textbox);
            this.Controls.Add(this.urun_adi_textbox);
            this.Controls.Add(this.urun_kodu_textbox);
            this.Controls.Add(this.Ekle_button);
            this.Name = "Urunler_Form";
            this.Text = "Urunler_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ekle_button;
        private System.Windows.Forms.TextBox urun_kodu_textbox;
        private System.Windows.Forms.TextBox urun_adi_textbox;
        private System.Windows.Forms.TextBox urun_stokMik_textbox;
        private System.Windows.Forms.TextBox urun_fiyat_textbox;
        private System.Windows.Forms.Label urunKodulbl;
        private System.Windows.Forms.Label urunAdilbl;
        private System.Windows.Forms.Label urunStoklbl;
        private System.Windows.Forms.Label urunFiyatlbl;
        private System.Windows.Forms.Label urunSillbl;
        private System.Windows.Forms.TextBox urunSiltextbox;
        private System.Windows.Forms.Button Urun_Sil_Button;
        private System.Windows.Forms.Label yeniUrunKodulbl;
        private System.Windows.Forms.Label yeniUrunAdilbl;
        private System.Windows.Forms.Label yeniUrunStoklbl;
        private System.Windows.Forms.Label yeniUrunFiyat;
        private System.Windows.Forms.TextBox yeniUrunKoduText;
        private System.Windows.Forms.TextBox yeniUrunAdiTextb;
        private System.Windows.Forms.TextBox yeniUrunStokMikText;
        private System.Windows.Forms.TextBox yeniUrunFiyatText;
        private System.Windows.Forms.Button GuncelleButton;
    }
}