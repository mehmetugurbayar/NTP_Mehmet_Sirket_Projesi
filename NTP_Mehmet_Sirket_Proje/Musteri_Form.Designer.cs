namespace NTP_Mehmet_Sirket_Proje
{
    partial class Musteri_Form
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
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtMsuteriAdres = new System.Windows.Forms.RichTextBox();
            this.MusteriKayitbtn = new System.Windows.Forms.Button();
            this.MusteriArabtn = new System.Windows.Forms.Button();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MusteriGuncellebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musteri Adı";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(105, 46);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAd.TabIndex = 1;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(105, 82);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Musteri Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adres";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(105, 139);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 8;
            // 
            // txtMsuteriAdres
            // 
            this.txtMsuteriAdres.Location = new System.Drawing.Point(105, 193);
            this.txtMsuteriAdres.Name = "txtMsuteriAdres";
            this.txtMsuteriAdres.Size = new System.Drawing.Size(176, 65);
            this.txtMsuteriAdres.TabIndex = 9;
            this.txtMsuteriAdres.Text = "";
            // 
            // MusteriKayitbtn
            // 
            this.MusteriKayitbtn.Location = new System.Drawing.Point(105, 278);
            this.MusteriKayitbtn.Name = "MusteriKayitbtn";
            this.MusteriKayitbtn.Size = new System.Drawing.Size(75, 23);
            this.MusteriKayitbtn.TabIndex = 10;
            this.MusteriKayitbtn.Text = "MusteriKayit";
            this.MusteriKayitbtn.UseVisualStyleBackColor = true;
            this.MusteriKayitbtn.Click += new System.EventHandler(this.MusteriKayitbtn_Click);
            // 
            // MusteriArabtn
            // 
            this.MusteriArabtn.Location = new System.Drawing.Point(145, 415);
            this.MusteriArabtn.Name = "MusteriArabtn";
            this.MusteriArabtn.Size = new System.Drawing.Size(75, 23);
            this.MusteriArabtn.TabIndex = 11;
            this.MusteriArabtn.Text = "Müşteri Ara";
            this.MusteriArabtn.UseVisualStyleBackColor = true;
            this.MusteriArabtn.Click += new System.EventHandler(this.MusteriArabtn_Click);
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(145, 385);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAra.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Müşteri Güncellemek için müşteri telefonunu girin";
            // 
            // MusteriGuncellebtn
            // 
            this.MusteriGuncellebtn.Location = new System.Drawing.Point(95, 278);
            this.MusteriGuncellebtn.Name = "MusteriGuncellebtn";
            this.MusteriGuncellebtn.Size = new System.Drawing.Size(110, 23);
            this.MusteriGuncellebtn.TabIndex = 14;
            this.MusteriGuncellebtn.Text = "Müşteriyi Güncelle";
            this.MusteriGuncellebtn.UseVisualStyleBackColor = true;
            this.MusteriGuncellebtn.Visible = false;
            this.MusteriGuncellebtn.Click += new System.EventHandler(this.MusteriGuncellebtn_Click);
            // 
            // Musteri_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.MusteriGuncellebtn);
            this.Controls.Add(this.txtMusteriAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MusteriArabtn);
            this.Controls.Add(this.MusteriKayitbtn);
            this.Controls.Add(this.txtMsuteriAdres);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.label1);
            this.Name = "Musteri_Form";
            this.Text = "Müşteri Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Musteri_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.RichTextBox txtMsuteriAdres;
        private System.Windows.Forms.Button MusteriKayitbtn;
        private System.Windows.Forms.Button MusteriArabtn;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MusteriGuncellebtn;
    }
}