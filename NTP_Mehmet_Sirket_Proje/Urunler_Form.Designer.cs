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
            this.URUN_ARA_BUTTON = new System.Windows.Forms.Button();
            this.urunAraTextbox = new System.Windows.Forms.TextBox();
            this.urun_counter_lbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlEkle = new System.Windows.Forms.Panel();
            this.pnlGuncelle = new System.Windows.Forms.Panel();
            this.pnlSil = new System.Windows.Forms.Panel();
            this.lblSilmeSonuc = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.pnlEkle.SuspendLayout();
            this.pnlGuncelle.SuspendLayout();
            this.pnlSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ekle_button
            // 
            this.Ekle_button.Location = new System.Drawing.Point(133, 164);
            this.Ekle_button.Name = "Ekle_button";
            this.Ekle_button.Size = new System.Drawing.Size(110, 23);
            this.Ekle_button.TabIndex = 0;
            this.Ekle_button.Text = "ÜRÜN KAYIT";
            this.Ekle_button.UseVisualStyleBackColor = true;
            this.Ekle_button.Click += new System.EventHandler(this.Ekle_button_Click);
            // 
            // urun_kodu_textbox
            // 
            this.urun_kodu_textbox.Location = new System.Drawing.Point(5, 4);
            this.urun_kodu_textbox.Name = "urun_kodu_textbox";
            this.urun_kodu_textbox.Size = new System.Drawing.Size(100, 20);
            this.urun_kodu_textbox.TabIndex = 1;
            // 
            // urun_adi_textbox
            // 
            this.urun_adi_textbox.Location = new System.Drawing.Point(5, 30);
            this.urun_adi_textbox.Name = "urun_adi_textbox";
            this.urun_adi_textbox.Size = new System.Drawing.Size(100, 20);
            this.urun_adi_textbox.TabIndex = 2;
            this.urun_adi_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urun_adi_textbox_KeyPress);
            // 
            // urun_stokMik_textbox
            // 
            this.urun_stokMik_textbox.Location = new System.Drawing.Point(5, 56);
            this.urun_stokMik_textbox.Name = "urun_stokMik_textbox";
            this.urun_stokMik_textbox.Size = new System.Drawing.Size(100, 20);
            this.urun_stokMik_textbox.TabIndex = 3;
            this.urun_stokMik_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urun_stokMik_textbox_KeyPress);
            // 
            // urun_fiyat_textbox
            // 
            this.urun_fiyat_textbox.Location = new System.Drawing.Point(5, 81);
            this.urun_fiyat_textbox.Name = "urun_fiyat_textbox";
            this.urun_fiyat_textbox.Size = new System.Drawing.Size(100, 20);
            this.urun_fiyat_textbox.TabIndex = 4;
            this.urun_fiyat_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urun_fiyat_textbox_KeyPress);
            // 
            // urunKodulbl
            // 
            this.urunKodulbl.AutoSize = true;
            this.urunKodulbl.Location = new System.Drawing.Point(45, 60);
            this.urunKodulbl.Name = "urunKodulbl";
            this.urunKodulbl.Size = new System.Drawing.Size(61, 13);
            this.urunKodulbl.TabIndex = 5;
            this.urunKodulbl.Text = "Urun Kodu:";
            // 
            // urunAdilbl
            // 
            this.urunAdilbl.AutoSize = true;
            this.urunAdilbl.Location = new System.Drawing.Point(45, 83);
            this.urunAdilbl.Name = "urunAdilbl";
            this.urunAdilbl.Size = new System.Drawing.Size(51, 13);
            this.urunAdilbl.TabIndex = 6;
            this.urunAdilbl.Text = "Urun Adı:";
            // 
            // urunStoklbl
            // 
            this.urunStoklbl.AutoSize = true;
            this.urunStoklbl.Location = new System.Drawing.Point(45, 106);
            this.urunStoklbl.Name = "urunStoklbl";
            this.urunStoklbl.Size = new System.Drawing.Size(92, 13);
            this.urunStoklbl.TabIndex = 7;
            this.urunStoklbl.Text = "Urun Stok Miktarı:";
            // 
            // urunFiyatlbl
            // 
            this.urunFiyatlbl.AutoSize = true;
            this.urunFiyatlbl.Location = new System.Drawing.Point(46, 132);
            this.urunFiyatlbl.Name = "urunFiyatlbl";
            this.urunFiyatlbl.Size = new System.Drawing.Size(60, 13);
            this.urunFiyatlbl.TabIndex = 8;
            this.urunFiyatlbl.Text = "Urun Fiyatı:";
            // 
            // urunSillbl
            // 
            this.urunSillbl.AutoSize = true;
            this.urunSillbl.Location = new System.Drawing.Point(524, 58);
            this.urunSillbl.Name = "urunSillbl";
            this.urunSillbl.Size = new System.Drawing.Size(107, 13);
            this.urunSillbl.TabIndex = 9;
            this.urunSillbl.Text = "Silinecek Ürün Kodu:";
            // 
            // urunSiltextbox
            // 
            this.urunSiltextbox.Location = new System.Drawing.Point(5, 6);
            this.urunSiltextbox.Name = "urunSiltextbox";
            this.urunSiltextbox.Size = new System.Drawing.Size(100, 20);
            this.urunSiltextbox.TabIndex = 10;
            // 
            // Urun_Sil_Button
            // 
            this.Urun_Sil_Button.Location = new System.Drawing.Point(637, 86);
            this.Urun_Sil_Button.Name = "Urun_Sil_Button";
            this.Urun_Sil_Button.Size = new System.Drawing.Size(110, 23);
            this.Urun_Sil_Button.TabIndex = 11;
            this.Urun_Sil_Button.Text = "ÜRÜN SİL";
            this.Urun_Sil_Button.UseVisualStyleBackColor = true;
            this.Urun_Sil_Button.Click += new System.EventHandler(this.Urun_Sil_Button_Click);
            // 
            // yeniUrunKodulbl
            // 
            this.yeniUrunKodulbl.AutoSize = true;
            this.yeniUrunKodulbl.Location = new System.Drawing.Point(268, 55);
            this.yeniUrunKodulbl.Name = "yeniUrunKodulbl";
            this.yeniUrunKodulbl.Size = new System.Drawing.Size(61, 13);
            this.yeniUrunKodulbl.TabIndex = 13;
            this.yeniUrunKodulbl.Text = "Ürün Kodu:";
            // 
            // yeniUrunAdilbl
            // 
            this.yeniUrunAdilbl.AutoSize = true;
            this.yeniUrunAdilbl.Location = new System.Drawing.Point(268, 83);
            this.yeniUrunAdilbl.Name = "yeniUrunAdilbl";
            this.yeniUrunAdilbl.Size = new System.Drawing.Size(75, 13);
            this.yeniUrunAdilbl.TabIndex = 14;
            this.yeniUrunAdilbl.Text = "Yeni Ürün Adı:";
            // 
            // yeniUrunStoklbl
            // 
            this.yeniUrunStoklbl.AutoSize = true;
            this.yeniUrunStoklbl.Location = new System.Drawing.Point(268, 111);
            this.yeniUrunStoklbl.Name = "yeniUrunStoklbl";
            this.yeniUrunStoklbl.Size = new System.Drawing.Size(113, 13);
            this.yeniUrunStoklbl.TabIndex = 15;
            this.yeniUrunStoklbl.Text = "Yeni Ürün Stok Miktaı:";
            // 
            // yeniUrunFiyat
            // 
            this.yeniUrunFiyat.AutoSize = true;
            this.yeniUrunFiyat.Location = new System.Drawing.Point(268, 139);
            this.yeniUrunFiyat.Name = "yeniUrunFiyat";
            this.yeniUrunFiyat.Size = new System.Drawing.Size(84, 13);
            this.yeniUrunFiyat.TabIndex = 16;
            this.yeniUrunFiyat.Text = "Yeni Urun Fiyatı:";
            // 
            // yeniUrunKoduText
            // 
            this.yeniUrunKoduText.Location = new System.Drawing.Point(5, 4);
            this.yeniUrunKoduText.Name = "yeniUrunKoduText";
            this.yeniUrunKoduText.Size = new System.Drawing.Size(100, 20);
            this.yeniUrunKoduText.TabIndex = 18;
            // 
            // yeniUrunAdiTextb
            // 
            this.yeniUrunAdiTextb.Location = new System.Drawing.Point(5, 30);
            this.yeniUrunAdiTextb.Name = "yeniUrunAdiTextb";
            this.yeniUrunAdiTextb.Size = new System.Drawing.Size(100, 20);
            this.yeniUrunAdiTextb.TabIndex = 19;
            // 
            // yeniUrunStokMikText
            // 
            this.yeniUrunStokMikText.Location = new System.Drawing.Point(5, 56);
            this.yeniUrunStokMikText.Name = "yeniUrunStokMikText";
            this.yeniUrunStokMikText.Size = new System.Drawing.Size(100, 20);
            this.yeniUrunStokMikText.TabIndex = 20;
            // 
            // yeniUrunFiyatText
            // 
            this.yeniUrunFiyatText.Location = new System.Drawing.Point(5, 82);
            this.yeniUrunFiyatText.Name = "yeniUrunFiyatText";
            this.yeniUrunFiyatText.Size = new System.Drawing.Size(100, 20);
            this.yeniUrunFiyatText.TabIndex = 21;
            // 
            // GuncelleButton
            // 
            this.GuncelleButton.Location = new System.Drawing.Point(394, 164);
            this.GuncelleButton.Name = "GuncelleButton";
            this.GuncelleButton.Size = new System.Drawing.Size(110, 23);
            this.GuncelleButton.TabIndex = 22;
            this.GuncelleButton.Text = "Güncelle";
            this.GuncelleButton.UseVisualStyleBackColor = true;
            this.GuncelleButton.Click += new System.EventHandler(this.GuncelleButton_Click);
            // 
            // URUN_ARA_BUTTON
            // 
            this.URUN_ARA_BUTTON.Location = new System.Drawing.Point(306, 224);
            this.URUN_ARA_BUTTON.Name = "URUN_ARA_BUTTON";
            this.URUN_ARA_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.URUN_ARA_BUTTON.TabIndex = 23;
            this.URUN_ARA_BUTTON.Text = "ÜRÜN ARA";
            this.URUN_ARA_BUTTON.UseVisualStyleBackColor = true;
            this.URUN_ARA_BUTTON.Click += new System.EventHandler(this.URUN_ARA_BUTTON_Click);
            // 
            // urunAraTextbox
            // 
            this.urunAraTextbox.Location = new System.Drawing.Point(387, 224);
            this.urunAraTextbox.Name = "urunAraTextbox";
            this.urunAraTextbox.Size = new System.Drawing.Size(100, 20);
            this.urunAraTextbox.TabIndex = 24;
            // 
            // urun_counter_lbl
            // 
            this.urun_counter_lbl.AutoEllipsis = true;
            this.urun_counter_lbl.AutoSize = true;
            this.urun_counter_lbl.Location = new System.Drawing.Point(23, 179);
            this.urun_counter_lbl.Name = "urun_counter_lbl";
            this.urun_counter_lbl.Size = new System.Drawing.Size(10, 13);
            this.urun_counter_lbl.TabIndex = 25;
            this.urun_counter_lbl.Text = " ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 253);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 198);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlEkle
            // 
            this.pnlEkle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEkle.Controls.Add(this.urun_kodu_textbox);
            this.pnlEkle.Controls.Add(this.urun_adi_textbox);
            this.pnlEkle.Controls.Add(this.urun_stokMik_textbox);
            this.pnlEkle.Controls.Add(this.urun_fiyat_textbox);
            this.pnlEkle.Location = new System.Drawing.Point(133, 49);
            this.pnlEkle.Name = "pnlEkle";
            this.pnlEkle.Size = new System.Drawing.Size(112, 110);
            this.pnlEkle.TabIndex = 27;
            // 
            // pnlGuncelle
            // 
            this.pnlGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGuncelle.Controls.Add(this.yeniUrunKoduText);
            this.pnlGuncelle.Controls.Add(this.yeniUrunAdiTextb);
            this.pnlGuncelle.Controls.Add(this.yeniUrunStokMikText);
            this.pnlGuncelle.Controls.Add(this.yeniUrunFiyatText);
            this.pnlGuncelle.Location = new System.Drawing.Point(394, 49);
            this.pnlGuncelle.Name = "pnlGuncelle";
            this.pnlGuncelle.Size = new System.Drawing.Size(110, 108);
            this.pnlGuncelle.TabIndex = 28;
            // 
            // pnlSil
            // 
            this.pnlSil.Controls.Add(this.urunSiltextbox);
            this.pnlSil.Location = new System.Drawing.Point(637, 49);
            this.pnlSil.Name = "pnlSil";
            this.pnlSil.Size = new System.Drawing.Size(110, 31);
            this.pnlSil.TabIndex = 29;
            // 
            // lblSilmeSonuc
            // 
            this.lblSilmeSonuc.AutoSize = true;
            this.lblSilmeSonuc.Location = new System.Drawing.Point(639, 123);
            this.lblSilmeSonuc.Name = "lblSilmeSonuc";
            this.lblSilmeSonuc.Size = new System.Drawing.Size(10, 13);
            this.lblSilmeSonuc.TabIndex = 30;
            this.lblSilmeSonuc.Text = " ";
            // 
            // Urunler_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSilmeSonuc);
            this.Controls.Add(this.urunAraTextbox);
            this.Controls.Add(this.pnlSil);
            this.Controls.Add(this.pnlGuncelle);
            this.Controls.Add(this.pnlEkle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.urun_counter_lbl);
            this.Controls.Add(this.URUN_ARA_BUTTON);
            this.Controls.Add(this.GuncelleButton);
            this.Controls.Add(this.yeniUrunFiyat);
            this.Controls.Add(this.yeniUrunStoklbl);
            this.Controls.Add(this.yeniUrunAdilbl);
            this.Controls.Add(this.yeniUrunKodulbl);
            this.Controls.Add(this.Urun_Sil_Button);
            this.Controls.Add(this.urunSillbl);
            this.Controls.Add(this.urunFiyatlbl);
            this.Controls.Add(this.urunStoklbl);
            this.Controls.Add(this.urunAdilbl);
            this.Controls.Add(this.urunKodulbl);
            this.Controls.Add(this.Ekle_button);
            this.Name = "Urunler_Form";
            this.Text = "Urunler_Form";
            this.Load += new System.EventHandler(this.Urunler_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.pnlEkle.ResumeLayout(false);
            this.pnlEkle.PerformLayout();
            this.pnlGuncelle.ResumeLayout(false);
            this.pnlGuncelle.PerformLayout();
            this.pnlSil.ResumeLayout(false);
            this.pnlSil.PerformLayout();
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
        private System.Windows.Forms.Button URUN_ARA_BUTTON;
        private System.Windows.Forms.TextBox urunAraTextbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlEkle;
        private System.Windows.Forms.Panel pnlGuncelle;
        private System.Windows.Forms.Panel pnlSil;
        public System.Windows.Forms.Label urun_counter_lbl;
        public System.Windows.Forms.Label lblSilmeSonuc;
    }
}