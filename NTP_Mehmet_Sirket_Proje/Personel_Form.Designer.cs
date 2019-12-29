namespace NTP_Mehmet_Sirket_Proje
{
    partial class Personel_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoTarihi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDoYeri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPzsyn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Personel_Ekle_Button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPerso_Sil = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Kayit_Sil = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGuncellePKodu = new System.Windows.Forms.TextBox();
            this.PersonelAraButton = new System.Windows.Forms.Button();
            this.GuncelleButton = new System.Windows.Forms.Button();
            this.pnlEkleGuncelle = new System.Windows.Forms.Panel();
            this.txtBaslaTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.lblGuncelleUyari = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.pnlAra = new System.Windows.Forms.Panel();
            this.pnlSil = new System.Windows.Forms.Panel();
            this.pnlTablo = new System.Windows.Forms.Panel();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.perso_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perso_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perso_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perso_cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogum_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogum_yeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozisyon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslama_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKaydetBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlEkleGuncelle.SuspendLayout();
            this.pnlAra.SuspendLayout();
            this.pnlSil.SuspendLayout();
            this.pnlTablo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Kodu";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(114, 34);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(100, 20);
            this.txtKod.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(114, 67);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Adı";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(114, 100);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personel Cinsiyeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Personel Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personel Mail";
            // 
            // txtDoTarihi
            // 
            this.txtDoTarihi.Location = new System.Drawing.Point(114, 232);
            this.txtDoTarihi.Name = "txtDoTarihi";
            this.txtDoTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtDoTarihi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dogum Tarihi";
            // 
            // txtDoYeri
            // 
            this.txtDoYeri.Location = new System.Drawing.Point(114, 265);
            this.txtDoYeri.Name = "txtDoYeri";
            this.txtDoYeri.Size = new System.Drawing.Size(100, 20);
            this.txtDoYeri.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Doğum Yeri";
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(114, 298);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(100, 20);
            this.txtUnvan.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Unvanı";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(114, 331);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 20);
            this.txtMaas.TabIndex = 19;
            this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Maaşı";
            // 
            // txtPzsyn
            // 
            this.txtPzsyn.Location = new System.Drawing.Point(114, 364);
            this.txtPzsyn.Name = "txtPzsyn";
            this.txtPzsyn.Size = new System.Drawing.Size(100, 20);
            this.txtPzsyn.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Çalışacağı Pozisyon";
            // 
            // Personel_Ekle_Button
            // 
            this.Personel_Ekle_Button.Location = new System.Drawing.Point(114, 441);
            this.Personel_Ekle_Button.Name = "Personel_Ekle_Button";
            this.Personel_Ekle_Button.Size = new System.Drawing.Size(100, 23);
            this.Personel_Ekle_Button.TabIndex = 22;
            this.Personel_Ekle_Button.Text = "Ekle";
            this.Personel_Ekle_Button.UseVisualStyleBackColor = true;
            this.Personel_Ekle_Button.Click += new System.EventHandler(this.Personel_Ekle_Button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "İşe Başlama Tarihi";
            // 
            // txtPerso_Sil
            // 
            this.txtPerso_Sil.Location = new System.Drawing.Point(155, 5);
            this.txtPerso_Sil.Name = "txtPerso_Sil";
            this.txtPerso_Sil.Size = new System.Drawing.Size(100, 20);
            this.txtPerso_Sil.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Silinecek Personel Kodu";
            // 
            // Kayit_Sil
            // 
            this.Kayit_Sil.BackColor = System.Drawing.Color.CadetBlue;
            this.Kayit_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayit_Sil.ForeColor = System.Drawing.Color.White;
            this.Kayit_Sil.Location = new System.Drawing.Point(262, 2);
            this.Kayit_Sil.Name = "Kayit_Sil";
            this.Kayit_Sil.Size = new System.Drawing.Size(75, 23);
            this.Kayit_Sil.TabIndex = 27;
            this.Kayit_Sil.Text = "Sil";
            this.Kayit_Sil.UseVisualStyleBackColor = false;
            this.Kayit_Sil.Click += new System.EventHandler(this.Kayit_Sil_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Güncellenecek Personel Kodu";
            // 
            // txtGuncellePKodu
            // 
            this.txtGuncellePKodu.Location = new System.Drawing.Point(155, 7);
            this.txtGuncellePKodu.Name = "txtGuncellePKodu";
            this.txtGuncellePKodu.Size = new System.Drawing.Size(100, 20);
            this.txtGuncellePKodu.TabIndex = 29;
            // 
            // PersonelAraButton
            // 
            this.PersonelAraButton.BackColor = System.Drawing.Color.CadetBlue;
            this.PersonelAraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelAraButton.ForeColor = System.Drawing.Color.White;
            this.PersonelAraButton.Location = new System.Drawing.Point(262, 5);
            this.PersonelAraButton.Name = "PersonelAraButton";
            this.PersonelAraButton.Size = new System.Drawing.Size(75, 23);
            this.PersonelAraButton.TabIndex = 30;
            this.PersonelAraButton.Text = "Ara";
            this.PersonelAraButton.UseVisualStyleBackColor = false;
            this.PersonelAraButton.Click += new System.EventHandler(this.PersonelAraButton_Click);
            // 
            // GuncelleButton
            // 
            this.GuncelleButton.BackColor = System.Drawing.Color.CadetBlue;
            this.GuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleButton.ForeColor = System.Drawing.Color.White;
            this.GuncelleButton.Location = new System.Drawing.Point(114, 442);
            this.GuncelleButton.Name = "GuncelleButton";
            this.GuncelleButton.Size = new System.Drawing.Size(100, 22);
            this.GuncelleButton.TabIndex = 31;
            this.GuncelleButton.Text = "Güncelle";
            this.GuncelleButton.UseVisualStyleBackColor = false;
            this.GuncelleButton.Visible = false;
            this.GuncelleButton.Click += new System.EventHandler(this.GuncelleButton_Click);
            // 
            // pnlEkleGuncelle
            // 
            this.pnlEkleGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEkleGuncelle.Controls.Add(this.txtBaslaTarihi);
            this.pnlEkleGuncelle.Controls.Add(this.txtMail);
            this.pnlEkleGuncelle.Controls.Add(this.txtTel);
            this.pnlEkleGuncelle.Controls.Add(this.lblGuncelleUyari);
            this.pnlEkleGuncelle.Controls.Add(this.txtKod);
            this.pnlEkleGuncelle.Controls.Add(this.txtCinsiyet);
            this.pnlEkleGuncelle.Controls.Add(this.label1);
            this.pnlEkleGuncelle.Controls.Add(this.GuncelleButton);
            this.pnlEkleGuncelle.Controls.Add(this.label2);
            this.pnlEkleGuncelle.Controls.Add(this.txtAd);
            this.pnlEkleGuncelle.Controls.Add(this.label3);
            this.pnlEkleGuncelle.Controls.Add(this.txtSoyad);
            this.pnlEkleGuncelle.Controls.Add(this.label4);
            this.pnlEkleGuncelle.Controls.Add(this.label5);
            this.pnlEkleGuncelle.Controls.Add(this.label12);
            this.pnlEkleGuncelle.Controls.Add(this.label6);
            this.pnlEkleGuncelle.Controls.Add(this.Personel_Ekle_Button);
            this.pnlEkleGuncelle.Controls.Add(this.txtPzsyn);
            this.pnlEkleGuncelle.Controls.Add(this.label7);
            this.pnlEkleGuncelle.Controls.Add(this.label11);
            this.pnlEkleGuncelle.Controls.Add(this.txtDoTarihi);
            this.pnlEkleGuncelle.Controls.Add(this.txtMaas);
            this.pnlEkleGuncelle.Controls.Add(this.label8);
            this.pnlEkleGuncelle.Controls.Add(this.label10);
            this.pnlEkleGuncelle.Controls.Add(this.txtDoYeri);
            this.pnlEkleGuncelle.Controls.Add(this.txtUnvan);
            this.pnlEkleGuncelle.Controls.Add(this.label9);
            this.pnlEkleGuncelle.Location = new System.Drawing.Point(12, 68);
            this.pnlEkleGuncelle.Name = "pnlEkleGuncelle";
            this.pnlEkleGuncelle.Size = new System.Drawing.Size(227, 471);
            this.pnlEkleGuncelle.TabIndex = 32;
            // 
            // txtBaslaTarihi
            // 
            this.txtBaslaTarihi.Location = new System.Drawing.Point(114, 399);
            this.txtBaslaTarihi.Mask = "00/00/0000";
            this.txtBaslaTarihi.Name = "txtBaslaTarihi";
            this.txtBaslaTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtBaslaTarihi.TabIndex = 38;
            this.txtBaslaTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(114, 199);
            this.txtMail.Mask = "AAAAAA@byr.com";
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 36;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(114, 166);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 37;
            // 
            // lblGuncelleUyari
            // 
            this.lblGuncelleUyari.AutoSize = true;
            this.lblGuncelleUyari.Location = new System.Drawing.Point(111, 18);
            this.lblGuncelleUyari.Name = "lblGuncelleUyari";
            this.lblGuncelleUyari.Size = new System.Drawing.Size(10, 13);
            this.lblGuncelleUyari.TabIndex = 33;
            this.lblGuncelleUyari.Text = " ";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(114, 136);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.txtCinsiyet.TabIndex = 7;
            // 
            // pnlAra
            // 
            this.pnlAra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAra.Controls.Add(this.label14);
            this.pnlAra.Controls.Add(this.txtGuncellePKodu);
            this.pnlAra.Controls.Add(this.PersonelAraButton);
            this.pnlAra.Location = new System.Drawing.Point(263, 68);
            this.pnlAra.Name = "pnlAra";
            this.pnlAra.Size = new System.Drawing.Size(363, 35);
            this.pnlAra.TabIndex = 33;
            // 
            // pnlSil
            // 
            this.pnlSil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSil.Controls.Add(this.label13);
            this.pnlSil.Controls.Add(this.txtPerso_Sil);
            this.pnlSil.Controls.Add(this.Kayit_Sil);
            this.pnlSil.Location = new System.Drawing.Point(263, 104);
            this.pnlSil.Name = "pnlSil";
            this.pnlSil.Size = new System.Drawing.Size(363, 31);
            this.pnlSil.TabIndex = 34;
            // 
            // pnlTablo
            // 
            this.pnlTablo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTablo.Controls.Add(this.dgvPersonel);
            this.pnlTablo.Location = new System.Drawing.Point(263, 170);
            this.pnlTablo.Name = "pnlTablo";
            this.pnlTablo.Size = new System.Drawing.Size(610, 369);
            this.pnlTablo.TabIndex = 35;
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AllowUserToDeleteRows = false;
            this.dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonel.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvPersonel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perso_kod,
            this.perso_ad,
            this.perso_soyad,
            this.perso_cinsiyet,
            this.tel,
            this.mail,
            this.dogum_tarih,
            this.dogum_yeri,
            this.unvan,
            this.maas,
            this.pozisyon,
            this.baslama_tarih});
            this.dgvPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonel.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.Size = new System.Drawing.Size(606, 365);
            this.dgvPersonel.TabIndex = 0;
            // 
            // perso_kod
            // 
            this.perso_kod.DataPropertyName = "perso_kod";
            this.perso_kod.HeaderText = "Personel Kodu";
            this.perso_kod.Name = "perso_kod";
            this.perso_kod.ReadOnly = true;
            // 
            // perso_ad
            // 
            this.perso_ad.DataPropertyName = "perso_ad";
            this.perso_ad.HeaderText = "Personel Adı";
            this.perso_ad.Name = "perso_ad";
            // 
            // perso_soyad
            // 
            this.perso_soyad.DataPropertyName = "perso_soyad";
            this.perso_soyad.HeaderText = "Personel Soyadı";
            this.perso_soyad.Name = "perso_soyad";
            // 
            // perso_cinsiyet
            // 
            this.perso_cinsiyet.DataPropertyName = "perso_cinsiyet";
            this.perso_cinsiyet.HeaderText = "Personel Cinsiyeti";
            this.perso_cinsiyet.Name = "perso_cinsiyet";
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "Telefon";
            this.tel.Name = "tel";
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "Mail Adresi";
            this.mail.Name = "mail";
            // 
            // dogum_tarih
            // 
            this.dogum_tarih.DataPropertyName = "dogum_tarih";
            this.dogum_tarih.HeaderText = "Doğum Tarihi";
            this.dogum_tarih.Name = "dogum_tarih";
            // 
            // dogum_yeri
            // 
            this.dogum_yeri.DataPropertyName = "dogum_yeri";
            this.dogum_yeri.HeaderText = "Doğum Yeri";
            this.dogum_yeri.Name = "dogum_yeri";
            // 
            // unvan
            // 
            this.unvan.DataPropertyName = "unvan";
            this.unvan.HeaderText = "Ünvanı";
            this.unvan.Name = "unvan";
            // 
            // maas
            // 
            this.maas.DataPropertyName = "maas";
            this.maas.HeaderText = "Maaşı";
            this.maas.Name = "maas";
            // 
            // pozisyon
            // 
            this.pozisyon.DataPropertyName = "pozisyon";
            this.pozisyon.HeaderText = "Çalıştığı Pozisyon";
            this.pozisyon.Name = "pozisyon";
            // 
            // baslama_tarih
            // 
            this.baslama_tarih.DataPropertyName = "baslama_tarih";
            this.baslama_tarih.HeaderText = "İşe Başlama Tarihi";
            this.baslama_tarih.Name = "baslama_tarih";
            // 
            // tblKaydetBtn
            // 
            this.tblKaydetBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.tblKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tblKaydetBtn.ForeColor = System.Drawing.Color.White;
            this.tblKaydetBtn.Location = new System.Drawing.Point(642, 113);
            this.tblKaydetBtn.Name = "tblKaydetBtn";
            this.tblKaydetBtn.Size = new System.Drawing.Size(229, 53);
            this.tblKaydetBtn.TabIndex = 40;
            this.tblKaydetBtn.Text = "Tablodaki Değişiklikleri Kaydet";
            this.tblKaydetBtn.UseVisualStyleBackColor = false;
            this.tblKaydetBtn.Click += new System.EventHandler(this.tblKaydetBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(12, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "Personel İşlemleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 62);
            this.panel1.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(773, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Personel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(891, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblKaydetBtn);
            this.Controls.Add(this.pnlTablo);
            this.Controls.Add(this.pnlSil);
            this.Controls.Add(this.pnlAra);
            this.Controls.Add(this.pnlEkleGuncelle);
            this.Name = "Personel_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.Personel_Form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Personel_Form_KeyPress);
            this.pnlEkleGuncelle.ResumeLayout(false);
            this.pnlEkleGuncelle.PerformLayout();
            this.pnlAra.ResumeLayout(false);
            this.pnlAra.PerformLayout();
            this.pnlSil.ResumeLayout(false);
            this.pnlSil.PerformLayout();
            this.pnlTablo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDoYeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPzsyn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPerso_Sil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Kayit_Sil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGuncellePKodu;
        private System.Windows.Forms.Button PersonelAraButton;
        private System.Windows.Forms.Panel pnlEkleGuncelle;
        public System.Windows.Forms.TextBox txtKod;
        public System.Windows.Forms.Button Personel_Ekle_Button;
        public System.Windows.Forms.Button GuncelleButton;
        private System.Windows.Forms.Label lblGuncelleUyari;
        private System.Windows.Forms.Panel pnlAra;
        private System.Windows.Forms.Panel pnlSil;
        private System.Windows.Forms.Panel pnlTablo;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtMail;
        private System.Windows.Forms.MaskedTextBox txtBaslaTarihi;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn perso_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn perso_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn perso_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn perso_cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogum_tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogum_yeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozisyon;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslama_tarih;
        private System.Windows.Forms.Button tblKaydetBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}