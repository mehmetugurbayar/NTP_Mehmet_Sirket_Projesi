namespace NTP_Mehmet_Sirket_Proje
{
    partial class Satis_Form
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
            this.txtSatisUrunKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisAdet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.satisButton = new System.Windows.Forms.Button();
            this.txtSatisTarih = new System.Windows.Forms.MaskedTextBox();
            this.dgvUrunTablo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriKod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.grpboxSatis = new System.Windows.Forms.GroupBox();
            this.pnlYeniMusteri = new System.Windows.Forms.Panel();
            this.pnlmusteriButon = new System.Windows.Forms.Panel();
            this.lblMusteriInfo = new System.Windows.Forms.Label();
            this.YeniMusteriEkle = new System.Windows.Forms.Button();
            this.dgvMusteriTablo = new System.Windows.Forms.DataGridView();
            this.TabloYenilebtn = new System.Windows.Forms.Button();
            this.dgvPersonelTablo = new System.Windows.Forms.DataGridView();
            this.perosnel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_mik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSatisKod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunTablo)).BeginInit();
            this.grpboxSatis.SuspendLayout();
            this.pnlYeniMusteri.SuspendLayout();
            this.pnlmusteriButon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSatisUrunKod
            // 
            this.txtSatisUrunKod.Location = new System.Drawing.Point(123, 136);
            this.txtSatisUrunKod.Name = "txtSatisUrunKod";
            this.txtSatisUrunKod.Size = new System.Drawing.Size(100, 20);
            this.txtSatisUrunKod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urun Kodunu girin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Urun Adeti";
            // 
            // txtSatisAdet
            // 
            this.txtSatisAdet.Location = new System.Drawing.Point(123, 216);
            this.txtSatisAdet.Name = "txtSatisAdet";
            this.txtSatisAdet.Size = new System.Drawing.Size(100, 20);
            this.txtSatisAdet.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam Tutar";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(123, 256);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyat.TabIndex = 6;
            // 
            // satisButton
            // 
            this.satisButton.Location = new System.Drawing.Point(123, 291);
            this.satisButton.Name = "satisButton";
            this.satisButton.Size = new System.Drawing.Size(100, 41);
            this.satisButton.TabIndex = 8;
            this.satisButton.Text = "SATIŞ";
            this.satisButton.UseVisualStyleBackColor = true;
            this.satisButton.Click += new System.EventHandler(this.satisButton_Click);
            // 
            // txtSatisTarih
            // 
            this.txtSatisTarih.Location = new System.Drawing.Point(123, 176);
            this.txtSatisTarih.Mask = "00/00/0000";
            this.txtSatisTarih.Name = "txtSatisTarih";
            this.txtSatisTarih.Size = new System.Drawing.Size(100, 20);
            this.txtSatisTarih.TabIndex = 9;
            this.txtSatisTarih.ValidatingType = typeof(System.DateTime);
            // 
            // dgvUrunTablo
            // 
            this.dgvUrunTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunid,
            this.urun_kodu,
            this.urun_ad,
            this.stok_mik,
            this.fiyat});
            this.dgvUrunTablo.Location = new System.Drawing.Point(378, 21);
            this.dgvUrunTablo.Name = "dgvUrunTablo";
            this.dgvUrunTablo.Size = new System.Drawing.Size(517, 123);
            this.dgvUrunTablo.TabIndex = 10;
            this.dgvUrunTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunTablo_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Musteri Kodunu/ID Girin";
            // 
            // txtMusteriKod
            // 
            this.txtMusteriKod.Location = new System.Drawing.Point(3, 19);
            this.txtMusteriKod.Name = "txtMusteriKod";
            this.txtMusteriKod.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriKod.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Personel Kod/ID Girin";
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Location = new System.Drawing.Point(123, 56);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelId.TabIndex = 13;
            // 
            // grpboxSatis
            // 
            this.grpboxSatis.Controls.Add(this.txtSatisKod);
            this.grpboxSatis.Controls.Add(this.label7);
            this.grpboxSatis.Controls.Add(this.pnlYeniMusteri);
            this.grpboxSatis.Controls.Add(this.txtPersonelId);
            this.grpboxSatis.Controls.Add(this.label6);
            this.grpboxSatis.Controls.Add(this.satisButton);
            this.grpboxSatis.Controls.Add(this.label5);
            this.grpboxSatis.Controls.Add(this.txtSatisUrunKod);
            this.grpboxSatis.Controls.Add(this.txtSatisAdet);
            this.grpboxSatis.Controls.Add(this.txtSatisFiyat);
            this.grpboxSatis.Controls.Add(this.label4);
            this.grpboxSatis.Controls.Add(this.label3);
            this.grpboxSatis.Controls.Add(this.txtSatisTarih);
            this.grpboxSatis.Controls.Add(this.label2);
            this.grpboxSatis.Controls.Add(this.label1);
            this.grpboxSatis.Location = new System.Drawing.Point(12, 12);
            this.grpboxSatis.Name = "grpboxSatis";
            this.grpboxSatis.Size = new System.Drawing.Size(328, 360);
            this.grpboxSatis.TabIndex = 15;
            this.grpboxSatis.TabStop = false;
            this.grpboxSatis.Text = "SATIŞ EKRANI";
            // 
            // pnlYeniMusteri
            // 
            this.pnlYeniMusteri.Controls.Add(this.pnlmusteriButon);
            this.pnlYeniMusteri.Controls.Add(this.txtMusteriKod);
            this.pnlYeniMusteri.Location = new System.Drawing.Point(122, 83);
            this.pnlYeniMusteri.Name = "pnlYeniMusteri";
            this.pnlYeniMusteri.Size = new System.Drawing.Size(206, 46);
            this.pnlYeniMusteri.TabIndex = 18;
            this.pnlYeniMusteri.MouseLeave += new System.EventHandler(this.pnlYeniMusteri_MouseLeave);
            this.pnlYeniMusteri.MouseHover += new System.EventHandler(this.pnlYeniMusteri_MouseHover);
            // 
            // pnlmusteriButon
            // 
            this.pnlmusteriButon.Controls.Add(this.lblMusteriInfo);
            this.pnlmusteriButon.Controls.Add(this.YeniMusteriEkle);
            this.pnlmusteriButon.Location = new System.Drawing.Point(109, 0);
            this.pnlmusteriButon.Name = "pnlmusteriButon";
            this.pnlmusteriButon.Size = new System.Drawing.Size(84, 43);
            this.pnlmusteriButon.TabIndex = 17;
            this.pnlmusteriButon.Visible = false;
            // 
            // lblMusteriInfo
            // 
            this.lblMusteriInfo.AutoSize = true;
            this.lblMusteriInfo.Location = new System.Drawing.Point(3, 0);
            this.lblMusteriInfo.Name = "lblMusteriInfo";
            this.lblMusteriInfo.Size = new System.Drawing.Size(10, 13);
            this.lblMusteriInfo.TabIndex = 16;
            this.lblMusteriInfo.Text = " ";
            // 
            // YeniMusteriEkle
            // 
            this.YeniMusteriEkle.Location = new System.Drawing.Point(3, 17);
            this.YeniMusteriEkle.Name = "YeniMusteriEkle";
            this.YeniMusteriEkle.Size = new System.Drawing.Size(77, 23);
            this.YeniMusteriEkle.TabIndex = 15;
            this.YeniMusteriEkle.Text = "Musteri Ekle";
            this.YeniMusteriEkle.UseVisualStyleBackColor = true;
            this.YeniMusteriEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMusteriTablo
            // 
            this.dgvMusteriTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteriTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteri_id,
            this.musteri_kod,
            this.musteri_ad,
            this.musteri_soyad,
            this.tel,
            this.adres});
            this.dgvMusteriTablo.Location = new System.Drawing.Point(378, 150);
            this.dgvMusteriTablo.Name = "dgvMusteriTablo";
            this.dgvMusteriTablo.Size = new System.Drawing.Size(517, 132);
            this.dgvMusteriTablo.TabIndex = 16;
            this.dgvMusteriTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriTablo_CellClick);
            // 
            // TabloYenilebtn
            // 
            this.TabloYenilebtn.Location = new System.Drawing.Point(901, 21);
            this.TabloYenilebtn.Name = "TabloYenilebtn";
            this.TabloYenilebtn.Size = new System.Drawing.Size(75, 23);
            this.TabloYenilebtn.TabIndex = 17;
            this.TabloYenilebtn.Text = "Yenile";
            this.TabloYenilebtn.UseVisualStyleBackColor = true;
            this.TabloYenilebtn.Click += new System.EventHandler(this.TabloYenilebtn_Click);
            // 
            // dgvPersonelTablo
            // 
            this.dgvPersonelTablo.AllowUserToAddRows = false;
            this.dgvPersonelTablo.AllowUserToDeleteRows = false;
            this.dgvPersonelTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonelTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perosnel_id,
            this.personel_kod,
            this.personel_ad});
            this.dgvPersonelTablo.Location = new System.Drawing.Point(378, 288);
            this.dgvPersonelTablo.Name = "dgvPersonelTablo";
            this.dgvPersonelTablo.ReadOnly = true;
            this.dgvPersonelTablo.Size = new System.Drawing.Size(517, 77);
            this.dgvPersonelTablo.TabIndex = 18;
            this.dgvPersonelTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonelTablo_CellClick);
            // 
            // perosnel_id
            // 
            this.perosnel_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.perosnel_id.DataPropertyName = "personel_id";
            this.perosnel_id.Frozen = true;
            this.perosnel_id.HeaderText = "Prsnlid";
            this.perosnel_id.MinimumWidth = 2;
            this.perosnel_id.Name = "perosnel_id";
            this.perosnel_id.ReadOnly = true;
            this.perosnel_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.perosnel_id.Visible = false;
            this.perosnel_id.Width = 2;
            // 
            // personel_kod
            // 
            this.personel_kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.personel_kod.DataPropertyName = "perso_kod";
            this.personel_kod.Frozen = true;
            this.personel_kod.HeaderText = "Personel Kodu";
            this.personel_kod.Name = "personel_kod";
            this.personel_kod.ReadOnly = true;
            this.personel_kod.Width = 237;
            // 
            // personel_ad
            // 
            this.personel_ad.DataPropertyName = "perso_ad";
            this.personel_ad.HeaderText = "Personel Adı";
            this.personel_ad.Name = "personel_ad";
            this.personel_ad.ReadOnly = true;
            // 
            // musteri_id
            // 
            this.musteri_id.DataPropertyName = "musterid";
            this.musteri_id.HeaderText = "musteri_id";
            this.musteri_id.Name = "musteri_id";
            this.musteri_id.Visible = false;
            // 
            // musteri_kod
            // 
            this.musteri_kod.DataPropertyName = "musteri_kod";
            this.musteri_kod.HeaderText = "Müşteri Kodu";
            this.musteri_kod.Name = "musteri_kod";
            // 
            // musteri_ad
            // 
            this.musteri_ad.DataPropertyName = "musteri_ad";
            this.musteri_ad.HeaderText = "Müşteri Adı";
            this.musteri_ad.Name = "musteri_ad";
            // 
            // musteri_soyad
            // 
            this.musteri_soyad.DataPropertyName = "musteri_soyad";
            this.musteri_soyad.HeaderText = "Müşteri Soyadı";
            this.musteri_soyad.Name = "musteri_soyad";
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "Telefon";
            this.tel.Name = "tel";
            // 
            // adres
            // 
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "Adres";
            this.adres.Name = "adres";
            // 
            // urunid
            // 
            this.urunid.DataPropertyName = "urun_id";
            this.urunid.HeaderText = "urn";
            this.urunid.Name = "urunid";
            this.urunid.Visible = false;
            // 
            // urun_kodu
            // 
            this.urun_kodu.DataPropertyName = "urun_kodu";
            this.urun_kodu.HeaderText = "Ürün Kodu";
            this.urun_kodu.Name = "urun_kodu";
            // 
            // urun_ad
            // 
            this.urun_ad.DataPropertyName = "urun_ad";
            this.urun_ad.HeaderText = "Ürün Adı";
            this.urun_ad.Name = "urun_ad";
            // 
            // stok_mik
            // 
            this.stok_mik.DataPropertyName = "stok_mik";
            this.stok_mik.HeaderText = "Kalan Ürün Miktarı";
            this.stok_mik.Name = "stok_mik";
            // 
            // fiyat
            // 
            this.fiyat.DataPropertyName = "fiyat";
            this.fiyat.HeaderText = "Adet Fiyatı";
            this.fiyat.Name = "fiyat";
            // 
            // txtSatisKod
            // 
            this.txtSatisKod.Location = new System.Drawing.Point(122, 30);
            this.txtSatisKod.Name = "txtSatisKod";
            this.txtSatisKod.Size = new System.Drawing.Size(100, 20);
            this.txtSatisKod.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Satış Kod Girin";
            // 
            // Satis_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 436);
            this.Controls.Add(this.dgvPersonelTablo);
            this.Controls.Add(this.TabloYenilebtn);
            this.Controls.Add(this.dgvMusteriTablo);
            this.Controls.Add(this.grpboxSatis);
            this.Controls.Add(this.dgvUrunTablo);
            this.Name = "Satis_Form";
            this.Text = "Satis_Form";
            this.Load += new System.EventHandler(this.Satis_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunTablo)).EndInit();
            this.grpboxSatis.ResumeLayout(false);
            this.grpboxSatis.PerformLayout();
            this.pnlYeniMusteri.ResumeLayout(false);
            this.pnlYeniMusteri.PerformLayout();
            this.pnlmusteriButon.ResumeLayout(false);
            this.pnlmusteriButon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSatisUrunKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatisAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.Button satisButton;
        private System.Windows.Forms.MaskedTextBox txtSatisTarih;
        private System.Windows.Forms.DataGridView dgvUrunTablo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteriKod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.GroupBox grpboxSatis;
        private System.Windows.Forms.Label lblMusteriInfo;
        private System.Windows.Forms.Button YeniMusteriEkle;
        private System.Windows.Forms.DataGridView dgvMusteriTablo;
        private System.Windows.Forms.Button TabloYenilebtn;
        private System.Windows.Forms.Panel pnlYeniMusteri;
        private System.Windows.Forms.Panel pnlmusteriButon;
        private System.Windows.Forms.DataGridView dgvPersonelTablo;
        private System.Windows.Forms.DataGridViewTextBoxColumn perosnel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunid;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_mik;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.TextBox txtSatisKod;
        private System.Windows.Forms.Label label7;
    }
}