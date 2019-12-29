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
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musteri Adı";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(129, 81);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(123, 20);
            this.txtMusteriAd.TabIndex = 1;
            this.txtMusteriAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriAd_KeyPress);
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(129, 119);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(123, 20);
            this.txtMusteriSoyad.TabIndex = 3;
            this.txtMusteriSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriSoyad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Musteri Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adres";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(129, 166);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(123, 20);
            this.txtTel.TabIndex = 8;
            // 
            // txtMsuteriAdres
            // 
            this.txtMsuteriAdres.Location = new System.Drawing.Point(62, 211);
            this.txtMsuteriAdres.Name = "txtMsuteriAdres";
            this.txtMsuteriAdres.Size = new System.Drawing.Size(242, 48);
            this.txtMsuteriAdres.TabIndex = 9;
            this.txtMsuteriAdres.Text = "";
            // 
            // MusteriKayitbtn
            // 
            this.MusteriKayitbtn.BackColor = System.Drawing.Color.CadetBlue;
            this.MusteriKayitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusteriKayitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriKayitbtn.ForeColor = System.Drawing.Color.White;
            this.MusteriKayitbtn.Location = new System.Drawing.Point(62, 265);
            this.MusteriKayitbtn.Name = "MusteriKayitbtn";
            this.MusteriKayitbtn.Size = new System.Drawing.Size(242, 40);
            this.MusteriKayitbtn.TabIndex = 10;
            this.MusteriKayitbtn.Text = "MusteriKayit";
            this.MusteriKayitbtn.UseVisualStyleBackColor = false;
            this.MusteriKayitbtn.Click += new System.EventHandler(this.MusteriKayitbtn_Click);
            // 
            // MusteriArabtn
            // 
            this.MusteriArabtn.BackColor = System.Drawing.Color.CadetBlue;
            this.MusteriArabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusteriArabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriArabtn.ForeColor = System.Drawing.Color.White;
            this.MusteriArabtn.Location = new System.Drawing.Point(62, 393);
            this.MusteriArabtn.Name = "MusteriArabtn";
            this.MusteriArabtn.Size = new System.Drawing.Size(242, 40);
            this.MusteriArabtn.TabIndex = 11;
            this.MusteriArabtn.Text = "Müşteri Ara";
            this.MusteriArabtn.UseVisualStyleBackColor = false;
            this.MusteriArabtn.Click += new System.EventHandler(this.MusteriArabtn_Click);
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(62, 357);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(242, 20);
            this.txtMusteriAra.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Güncelleme yapmak için adı girin";
            // 
            // MusteriGuncellebtn
            // 
            this.MusteriGuncellebtn.BackColor = System.Drawing.Color.CadetBlue;
            this.MusteriGuncellebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusteriGuncellebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriGuncellebtn.ForeColor = System.Drawing.Color.White;
            this.MusteriGuncellebtn.Location = new System.Drawing.Point(62, 265);
            this.MusteriGuncellebtn.Name = "MusteriGuncellebtn";
            this.MusteriGuncellebtn.Size = new System.Drawing.Size(242, 40);
            this.MusteriGuncellebtn.TabIndex = 14;
            this.MusteriGuncellebtn.Text = "Müşteriyi Güncelle";
            this.MusteriGuncellebtn.UseVisualStyleBackColor = false;
            this.MusteriGuncellebtn.Visible = false;
            this.MusteriGuncellebtn.Click += new System.EventHandler(this.MusteriGuncellebtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(217, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri İşlemleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 62);
            this.panel1.TabIndex = 15;
            // 
            // Musteri_Form
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(337, 452);
            this.Controls.Add(this.panel1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.Musteri_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}