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
            this.pnlEkle = new System.Windows.Forms.Panel();
            this.pnlGuncelle = new System.Windows.Forms.Panel();
            this.pnlSil = new System.Windows.Forms.Panel();
            this.lblSilmeSonuc = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv_urun_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_urun_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_stok_mik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_urun_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKaydetButton = new System.Windows.Forms.Button();
            this.Yenilebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEkle.SuspendLayout();
            this.pnlGuncelle.SuspendLayout();
            this.pnlSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ekle_button
            // 
            this.Ekle_button.BackColor = System.Drawing.Color.CadetBlue;
            this.Ekle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle_button.ForeColor = System.Drawing.Color.White;
            this.Ekle_button.Location = new System.Drawing.Point(145, 164);
            this.Ekle_button.Name = "Ekle_button";
            this.Ekle_button.Size = new System.Drawing.Size(128, 28);
            this.Ekle_button.TabIndex = 0;
            this.Ekle_button.Text = "ÜRÜN KAYIT";
            this.Ekle_button.UseVisualStyleBackColor = false;
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
            this.urunKodulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunKodulbl.Location = new System.Drawing.Point(7, 60);
            this.urunKodulbl.Name = "urunKodulbl";
            this.urunKodulbl.Size = new System.Drawing.Size(99, 20);
            this.urunKodulbl.TabIndex = 5;
            this.urunKodulbl.Text = "Urun Kodu:";
            // 
            // urunAdilbl
            // 
            this.urunAdilbl.AutoSize = true;
            this.urunAdilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdilbl.Location = new System.Drawing.Point(7, 83);
            this.urunAdilbl.Name = "urunAdilbl";
            this.urunAdilbl.Size = new System.Drawing.Size(84, 20);
            this.urunAdilbl.TabIndex = 6;
            this.urunAdilbl.Text = "Urun Adı:";
            // 
            // urunStoklbl
            // 
            this.urunStoklbl.AutoSize = true;
            this.urunStoklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunStoklbl.Location = new System.Drawing.Point(7, 106);
            this.urunStoklbl.Name = "urunStoklbl";
            this.urunStoklbl.Size = new System.Drawing.Size(153, 20);
            this.urunStoklbl.TabIndex = 7;
            this.urunStoklbl.Text = "Urun Stok Miktarı:";
            // 
            // urunFiyatlbl
            // 
            this.urunFiyatlbl.AutoSize = true;
            this.urunFiyatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFiyatlbl.Location = new System.Drawing.Point(8, 132);
            this.urunFiyatlbl.Name = "urunFiyatlbl";
            this.urunFiyatlbl.Size = new System.Drawing.Size(101, 20);
            this.urunFiyatlbl.TabIndex = 8;
            this.urunFiyatlbl.Text = "Urun Fiyatı:";
            // 
            // urunSillbl
            // 
            this.urunSillbl.AutoSize = true;
            this.urunSillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunSillbl.Location = new System.Drawing.Point(526, 61);
            this.urunSillbl.Name = "urunSillbl";
            this.urunSillbl.Size = new System.Drawing.Size(176, 20);
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
            this.Urun_Sil_Button.BackColor = System.Drawing.Color.CadetBlue;
            this.Urun_Sil_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urun_Sil_Button.ForeColor = System.Drawing.Color.White;
            this.Urun_Sil_Button.Location = new System.Drawing.Point(698, 90);
            this.Urun_Sil_Button.Name = "Urun_Sil_Button";
            this.Urun_Sil_Button.Size = new System.Drawing.Size(110, 25);
            this.Urun_Sil_Button.TabIndex = 11;
            this.Urun_Sil_Button.Text = "ÜRÜN SİL";
            this.Urun_Sil_Button.UseVisualStyleBackColor = false;
            this.Urun_Sil_Button.Click += new System.EventHandler(this.Urun_Sil_Button_Click);
            // 
            // yeniUrunKodulbl
            // 
            this.yeniUrunKodulbl.AutoSize = true;
            this.yeniUrunKodulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniUrunKodulbl.Location = new System.Drawing.Point(270, 55);
            this.yeniUrunKodulbl.Name = "yeniUrunKodulbl";
            this.yeniUrunKodulbl.Size = new System.Drawing.Size(99, 20);
            this.yeniUrunKodulbl.TabIndex = 13;
            this.yeniUrunKodulbl.Text = "Ürün Kodu:";
            // 
            // yeniUrunAdilbl
            // 
            this.yeniUrunAdilbl.AutoSize = true;
            this.yeniUrunAdilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniUrunAdilbl.Location = new System.Drawing.Point(270, 83);
            this.yeniUrunAdilbl.Name = "yeniUrunAdilbl";
            this.yeniUrunAdilbl.Size = new System.Drawing.Size(125, 20);
            this.yeniUrunAdilbl.TabIndex = 14;
            this.yeniUrunAdilbl.Text = "Yeni Ürün Adı:";
            // 
            // yeniUrunStoklbl
            // 
            this.yeniUrunStoklbl.AutoSize = true;
            this.yeniUrunStoklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniUrunStoklbl.Location = new System.Drawing.Point(270, 111);
            this.yeniUrunStoklbl.Name = "yeniUrunStoklbl";
            this.yeniUrunStoklbl.Size = new System.Drawing.Size(144, 20);
            this.yeniUrunStoklbl.TabIndex = 15;
            this.yeniUrunStoklbl.Text = "Yeni Stok Miktaı:";
            // 
            // yeniUrunFiyat
            // 
            this.yeniUrunFiyat.AutoSize = true;
            this.yeniUrunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniUrunFiyat.Location = new System.Drawing.Point(270, 139);
            this.yeniUrunFiyat.Name = "yeniUrunFiyat";
            this.yeniUrunFiyat.Size = new System.Drawing.Size(98, 20);
            this.yeniUrunFiyat.TabIndex = 16;
            this.yeniUrunFiyat.Text = "Yeni Fiyatı:";
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
            this.GuncelleButton.BackColor = System.Drawing.Color.CadetBlue;
            this.GuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleButton.ForeColor = System.Drawing.Color.White;
            this.GuncelleButton.Location = new System.Drawing.Point(410, 166);
            this.GuncelleButton.Name = "GuncelleButton";
            this.GuncelleButton.Size = new System.Drawing.Size(110, 26);
            this.GuncelleButton.TabIndex = 22;
            this.GuncelleButton.Text = "GÜNCELLE";
            this.GuncelleButton.UseVisualStyleBackColor = false;
            this.GuncelleButton.Click += new System.EventHandler(this.GuncelleButton_Click);
            // 
            // URUN_ARA_BUTTON
            // 
            this.URUN_ARA_BUTTON.BackColor = System.Drawing.Color.CadetBlue;
            this.URUN_ARA_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.URUN_ARA_BUTTON.ForeColor = System.Drawing.Color.White;
            this.URUN_ARA_BUTTON.Location = new System.Drawing.Point(29, 211);
            this.URUN_ARA_BUTTON.Name = "URUN_ARA_BUTTON";
            this.URUN_ARA_BUTTON.Size = new System.Drawing.Size(111, 27);
            this.URUN_ARA_BUTTON.TabIndex = 23;
            this.URUN_ARA_BUTTON.Text = "ÜRÜN ARA";
            this.URUN_ARA_BUTTON.UseVisualStyleBackColor = false;
            this.URUN_ARA_BUTTON.Click += new System.EventHandler(this.URUN_ARA_BUTTON_Click);
            // 
            // urunAraTextbox
            // 
            this.urunAraTextbox.Location = new System.Drawing.Point(145, 216);
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
            // pnlEkle
            // 
            this.pnlEkle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEkle.Controls.Add(this.urun_kodu_textbox);
            this.pnlEkle.Controls.Add(this.urun_adi_textbox);
            this.pnlEkle.Controls.Add(this.urun_stokMik_textbox);
            this.pnlEkle.Controls.Add(this.urun_fiyat_textbox);
            this.pnlEkle.Location = new System.Drawing.Point(152, 49);
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
            this.pnlGuncelle.Location = new System.Drawing.Point(410, 51);
            this.pnlGuncelle.Name = "pnlGuncelle";
            this.pnlGuncelle.Size = new System.Drawing.Size(110, 108);
            this.pnlGuncelle.TabIndex = 28;
            // 
            // pnlSil
            // 
            this.pnlSil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSil.Controls.Add(this.urunSiltextbox);
            this.pnlSil.Location = new System.Drawing.Point(698, 56);
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
            // dgv1
            // 
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_urun_kodu,
            this.dgv_urun_ad,
            this.dgv_stok_mik,
            this.dgv_urun_fiyat});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv1.Location = new System.Drawing.Point(0, 244);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(812, 181);
            this.dgv1.TabIndex = 31;
            this.dgv1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv1_KeyPress);
            // 
            // dgv_urun_kodu
            // 
            this.dgv_urun_kodu.DataPropertyName = "urun_kodu";
            this.dgv_urun_kodu.HeaderText = "Ürün Kodu";
            this.dgv_urun_kodu.Name = "dgv_urun_kodu";
            // 
            // dgv_urun_ad
            // 
            this.dgv_urun_ad.DataPropertyName = "urun_ad";
            this.dgv_urun_ad.HeaderText = "Ürün Adı";
            this.dgv_urun_ad.Name = "dgv_urun_ad";
            // 
            // dgv_stok_mik
            // 
            this.dgv_stok_mik.DataPropertyName = "stok_mik";
            this.dgv_stok_mik.HeaderText = "Stok Miktarı";
            this.dgv_stok_mik.Name = "dgv_stok_mik";
            // 
            // dgv_urun_fiyat
            // 
            this.dgv_urun_fiyat.DataPropertyName = "fiyat";
            this.dgv_urun_fiyat.HeaderText = "Fiyat Bilgisi";
            this.dgv_urun_fiyat.Name = "dgv_urun_fiyat";
            // 
            // tblKaydetButton
            // 
            this.tblKaydetButton.BackColor = System.Drawing.Color.CadetBlue;
            this.tblKaydetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tblKaydetButton.ForeColor = System.Drawing.Color.White;
            this.tblKaydetButton.Location = new System.Drawing.Point(567, 210);
            this.tblKaydetButton.Name = "tblKaydetButton";
            this.tblKaydetButton.Size = new System.Drawing.Size(220, 29);
            this.tblKaydetButton.TabIndex = 32;
            this.tblKaydetButton.Text = "Tablo Değişiklikleri Kaydet";
            this.tblKaydetButton.UseVisualStyleBackColor = false;
            this.tblKaydetButton.Click += new System.EventHandler(this.tblKaydetButton_Click);
            // 
            // Yenilebtn
            // 
            this.Yenilebtn.BackColor = System.Drawing.Color.CadetBlue;
            this.Yenilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenilebtn.ForeColor = System.Drawing.Color.White;
            this.Yenilebtn.Location = new System.Drawing.Point(479, 211);
            this.Yenilebtn.Name = "Yenilebtn";
            this.Yenilebtn.Size = new System.Drawing.Size(82, 27);
            this.Yenilebtn.TabIndex = 33;
            this.Yenilebtn.Text = "Yenile";
            this.Yenilebtn.UseVisualStyleBackColor = false;
            this.Yenilebtn.Click += new System.EventHandler(this.Yenilebtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(693, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ürün İşlemleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 46);
            this.panel1.TabIndex = 34;
            // 
            // Urunler_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(812, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Yenilebtn);
            this.Controls.Add(this.tblKaydetButton);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lblSilmeSonuc);
            this.Controls.Add(this.urunAraTextbox);
            this.Controls.Add(this.pnlSil);
            this.Controls.Add(this.pnlGuncelle);
            this.Controls.Add(this.pnlEkle);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.Urunler_Form_Load);
            this.pnlEkle.ResumeLayout(false);
            this.pnlEkle.PerformLayout();
            this.pnlGuncelle.ResumeLayout(false);
            this.pnlGuncelle.PerformLayout();
            this.pnlSil.ResumeLayout(false);
            this.pnlSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel pnlEkle;
        private System.Windows.Forms.Panel pnlGuncelle;
        private System.Windows.Forms.Panel pnlSil;
        public System.Windows.Forms.Label urun_counter_lbl;
        public System.Windows.Forms.Label lblSilmeSonuc;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button tblKaydetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_urun_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_urun_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_stok_mik;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_urun_fiyat;
        private System.Windows.Forms.Button Yenilebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}