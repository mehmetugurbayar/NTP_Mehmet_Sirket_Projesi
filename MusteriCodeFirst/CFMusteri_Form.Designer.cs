namespace MusteriCodeFirst
{
    partial class CFMusteri_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmusteriKod = new System.Windows.Forms.TextBox();
            this.txtmusteriAd = new System.Windows.Forms.TextBox();
            this.txtmusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtmusteriTel = new System.Windows.Forms.TextBox();
            this.txtmusteriAdres = new System.Windows.Forms.TextBox();
            this.urunFiyatlbl = new System.Windows.Forms.Label();
            this.urunStoklbl = new System.Windows.Forms.Label();
            this.urunAdilbl = new System.Windows.Forms.Label();
            this.urunKodulbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Msuteri_Sil_Button = new System.Windows.Forms.Button();
            this.urunSillbl = new System.Windows.Forms.Label();
            this.musterSiltextbox = new System.Windows.Forms.TextBox();
            this.Ekle_button = new System.Windows.Forms.Button();
            this.yeniUrunKodulbl = new System.Windows.Forms.Label();
            this.yeniMusteriKoduText = new System.Windows.Forms.TextBox();
            this.yeniUrunAdilbl = new System.Windows.Forms.Label();
            this.yeniMsuteriAdiTextb = new System.Windows.Forms.TextBox();
            this.yeniUrunStoklbl = new System.Windows.Forms.Label();
            this.yenimMusteriStokMikText = new System.Windows.Forms.TextBox();
            this.yeniUrunFiyat = new System.Windows.Forms.Label();
            this.yeniMusteriFiyatText = new System.Windows.Forms.TextBox();
            this.GuncelleButton = new System.Windows.Forms.Button();
            this.yeniMusteriFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtmusteriKod
            // 
            this.txtmusteriKod.Location = new System.Drawing.Point(76, 29);
            this.txtmusteriKod.Name = "txtmusteriKod";
            this.txtmusteriKod.Size = new System.Drawing.Size(100, 20);
            this.txtmusteriKod.TabIndex = 4;
            // 
            // txtmusteriAd
            // 
            this.txtmusteriAd.Location = new System.Drawing.Point(76, 55);
            this.txtmusteriAd.Name = "txtmusteriAd";
            this.txtmusteriAd.Size = new System.Drawing.Size(100, 20);
            this.txtmusteriAd.TabIndex = 5;
            // 
            // txtmusteriSoyad
            // 
            this.txtmusteriSoyad.Location = new System.Drawing.Point(76, 81);
            this.txtmusteriSoyad.Name = "txtmusteriSoyad";
            this.txtmusteriSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtmusteriSoyad.TabIndex = 6;
            // 
            // txtmusteriTel
            // 
            this.txtmusteriTel.Location = new System.Drawing.Point(76, 107);
            this.txtmusteriTel.Name = "txtmusteriTel";
            this.txtmusteriTel.Size = new System.Drawing.Size(100, 20);
            this.txtmusteriTel.TabIndex = 7;
            // 
            // txtmusteriAdres
            // 
            this.txtmusteriAdres.Location = new System.Drawing.Point(76, 133);
            this.txtmusteriAdres.Name = "txtmusteriAdres";
            this.txtmusteriAdres.Size = new System.Drawing.Size(100, 20);
            this.txtmusteriAdres.TabIndex = 8;
            // 
            // urunFiyatlbl
            // 
            this.urunFiyatlbl.AutoSize = true;
            this.urunFiyatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFiyatlbl.Location = new System.Drawing.Point(12, 107);
            this.urunFiyatlbl.Name = "urunFiyatlbl";
            this.urunFiyatlbl.Size = new System.Drawing.Size(33, 20);
            this.urunFiyatlbl.TabIndex = 12;
            this.urunFiyatlbl.Text = "Tel";
            // 
            // urunStoklbl
            // 
            this.urunStoklbl.AutoSize = true;
            this.urunStoklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunStoklbl.Location = new System.Drawing.Point(8, 81);
            this.urunStoklbl.Name = "urunStoklbl";
            this.urunStoklbl.Size = new System.Drawing.Size(59, 20);
            this.urunStoklbl.TabIndex = 11;
            this.urunStoklbl.Text = "Soyad";
            // 
            // urunAdilbl
            // 
            this.urunAdilbl.AutoSize = true;
            this.urunAdilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdilbl.Location = new System.Drawing.Point(9, 55);
            this.urunAdilbl.Name = "urunAdilbl";
            this.urunAdilbl.Size = new System.Drawing.Size(31, 20);
            this.urunAdilbl.TabIndex = 10;
            this.urunAdilbl.Text = "Ad";
            // 
            // urunKodulbl
            // 
            this.urunKodulbl.AutoSize = true;
            this.urunKodulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunKodulbl.Location = new System.Drawing.Point(8, 29);
            this.urunKodulbl.Name = "urunKodulbl";
            this.urunKodulbl.Size = new System.Drawing.Size(40, 20);
            this.urunKodulbl.TabIndex = 9;
            this.urunKodulbl.Text = "Kod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adres";
            // 
            // Msuteri_Sil_Button
            // 
            this.Msuteri_Sil_Button.BackColor = System.Drawing.Color.CadetBlue;
            this.Msuteri_Sil_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Msuteri_Sil_Button.ForeColor = System.Drawing.Color.White;
            this.Msuteri_Sil_Button.Location = new System.Drawing.Point(385, 57);
            this.Msuteri_Sil_Button.Name = "Msuteri_Sil_Button";
            this.Msuteri_Sil_Button.Size = new System.Drawing.Size(100, 25);
            this.Msuteri_Sil_Button.TabIndex = 16;
            this.Msuteri_Sil_Button.Text = "Sil";
            this.Msuteri_Sil_Button.UseVisualStyleBackColor = false;
            this.Msuteri_Sil_Button.Click += new System.EventHandler(this.Msuteri_Sil_Button_Click);
            // 
            // urunSillbl
            // 
            this.urunSillbl.AutoSize = true;
            this.urunSillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunSillbl.Location = new System.Drawing.Point(203, 31);
            this.urunSillbl.Name = "urunSillbl";
            this.urunSillbl.Size = new System.Drawing.Size(170, 20);
            this.urunSillbl.TabIndex = 14;
            this.urunSillbl.Text = "Silinecek Müs Kodu:";
            // 
            // musterSiltextbox
            // 
            this.musterSiltextbox.Location = new System.Drawing.Point(385, 31);
            this.musterSiltextbox.Name = "musterSiltextbox";
            this.musterSiltextbox.Size = new System.Drawing.Size(100, 20);
            this.musterSiltextbox.TabIndex = 15;
            // 
            // Ekle_button
            // 
            this.Ekle_button.BackColor = System.Drawing.Color.CadetBlue;
            this.Ekle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle_button.ForeColor = System.Drawing.Color.White;
            this.Ekle_button.Location = new System.Drawing.Point(76, 159);
            this.Ekle_button.Name = "Ekle_button";
            this.Ekle_button.Size = new System.Drawing.Size(100, 28);
            this.Ekle_button.TabIndex = 17;
            this.Ekle_button.Text = "Ekle";
            this.Ekle_button.UseVisualStyleBackColor = false;
            this.Ekle_button.Click += new System.EventHandler(this.Ekle_button_Click);
            // 
            // yeniUrunKodulbl
            // 
            this.yeniUrunKodulbl.AutoSize = true;
            this.yeniUrunKodulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniUrunKodulbl.Location = new System.Drawing.Point(511, 59);
            this.yeniUrunKodulbl.Name = "yeniUrunKodulbl";
            this.yeniUrunKodulbl.Size = new System.Drawing.Size(99, 20);
            this.yeniUrunKodulbl.TabIndex = 23;
            this.yeniUrunKodulbl.Text = "Ürün Kodu:";
            // 
            // yeniMusteriKoduText
            // 
            this.yeniMusteriKoduText.Location = new System.Drawing.Point(665, 33);
            this.yeniMusteriKoduText.Name = "yeniMusteriKoduText";
            this.yeniMusteriKoduText.Size = new System.Drawing.Size(100, 20);
            this.yeniMusteriKoduText.TabIndex = 27;
            // 
            // yeniUrunAdilbl
            // 
            this.yeniUrunAdilbl.AutoSize = true;
            this.yeniUrunAdilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniUrunAdilbl.Location = new System.Drawing.Point(511, 85);
            this.yeniUrunAdilbl.Name = "yeniUrunAdilbl";
            this.yeniUrunAdilbl.Size = new System.Drawing.Size(125, 20);
            this.yeniUrunAdilbl.TabIndex = 24;
            this.yeniUrunAdilbl.Text = "Yeni Ürün Adı:";
            // 
            // yeniMsuteriAdiTextb
            // 
            this.yeniMsuteriAdiTextb.Location = new System.Drawing.Point(665, 59);
            this.yeniMsuteriAdiTextb.Name = "yeniMsuteriAdiTextb";
            this.yeniMsuteriAdiTextb.Size = new System.Drawing.Size(100, 20);
            this.yeniMsuteriAdiTextb.TabIndex = 28;
            // 
            // yeniUrunStoklbl
            // 
            this.yeniUrunStoklbl.AutoSize = true;
            this.yeniUrunStoklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniUrunStoklbl.Location = new System.Drawing.Point(510, 111);
            this.yeniUrunStoklbl.Name = "yeniUrunStoklbl";
            this.yeniUrunStoklbl.Size = new System.Drawing.Size(144, 20);
            this.yeniUrunStoklbl.TabIndex = 25;
            this.yeniUrunStoklbl.Text = "Yeni Stok Miktaı:";
            // 
            // yenimMusteriStokMikText
            // 
            this.yenimMusteriStokMikText.Location = new System.Drawing.Point(665, 85);
            this.yenimMusteriStokMikText.Name = "yenimMusteriStokMikText";
            this.yenimMusteriStokMikText.Size = new System.Drawing.Size(100, 20);
            this.yenimMusteriStokMikText.TabIndex = 29;
            // 
            // yeniUrunFiyat
            // 
            this.yeniUrunFiyat.AutoSize = true;
            this.yeniUrunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniUrunFiyat.Location = new System.Drawing.Point(511, 137);
            this.yeniUrunFiyat.Name = "yeniUrunFiyat";
            this.yeniUrunFiyat.Size = new System.Drawing.Size(98, 20);
            this.yeniUrunFiyat.TabIndex = 26;
            this.yeniUrunFiyat.Text = "Yeni Fiyatı:";
            // 
            // yeniMusteriFiyatText
            // 
            this.yeniMusteriFiyatText.Location = new System.Drawing.Point(665, 111);
            this.yeniMusteriFiyatText.Name = "yeniMusteriFiyatText";
            this.yeniMusteriFiyatText.Size = new System.Drawing.Size(100, 20);
            this.yeniMusteriFiyatText.TabIndex = 30;
            // 
            // GuncelleButton
            // 
            this.GuncelleButton.BackColor = System.Drawing.Color.CadetBlue;
            this.GuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleButton.ForeColor = System.Drawing.Color.White;
            this.GuncelleButton.Location = new System.Drawing.Point(665, 161);
            this.GuncelleButton.Name = "GuncelleButton";
            this.GuncelleButton.Size = new System.Drawing.Size(110, 26);
            this.GuncelleButton.TabIndex = 31;
            this.GuncelleButton.Text = "GÜNCELLE";
            this.GuncelleButton.UseVisualStyleBackColor = false;
            // 
            // yeniMusteriFiyat
            // 
            this.yeniMusteriFiyat.Location = new System.Drawing.Point(665, 137);
            this.yeniMusteriFiyat.Name = "yeniMusteriFiyat";
            this.yeniMusteriFiyat.Size = new System.Drawing.Size(100, 20);
            this.yeniMusteriFiyat.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(510, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ürün Kodu:";
            // 
            // CFMusteri_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yeniMusteriFiyat);
            this.Controls.Add(this.yeniUrunKodulbl);
            this.Controls.Add(this.yeniMusteriKoduText);
            this.Controls.Add(this.yeniUrunAdilbl);
            this.Controls.Add(this.yeniMsuteriAdiTextb);
            this.Controls.Add(this.yeniUrunStoklbl);
            this.Controls.Add(this.yenimMusteriStokMikText);
            this.Controls.Add(this.yeniUrunFiyat);
            this.Controls.Add(this.yeniMusteriFiyatText);
            this.Controls.Add(this.GuncelleButton);
            this.Controls.Add(this.Ekle_button);
            this.Controls.Add(this.Msuteri_Sil_Button);
            this.Controls.Add(this.urunSillbl);
            this.Controls.Add(this.musterSiltextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunFiyatlbl);
            this.Controls.Add(this.urunStoklbl);
            this.Controls.Add(this.urunAdilbl);
            this.Controls.Add(this.urunKodulbl);
            this.Controls.Add(this.txtmusteriAdres);
            this.Controls.Add(this.txtmusteriTel);
            this.Controls.Add(this.txtmusteriSoyad);
            this.Controls.Add(this.txtmusteriAd);
            this.Controls.Add(this.txtmusteriKod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CFMusteri_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmusteriKod;
        private System.Windows.Forms.TextBox txtmusteriAd;
        private System.Windows.Forms.TextBox txtmusteriSoyad;
        private System.Windows.Forms.TextBox txtmusteriTel;
        private System.Windows.Forms.TextBox txtmusteriAdres;
        private System.Windows.Forms.Label urunFiyatlbl;
        private System.Windows.Forms.Label urunStoklbl;
        private System.Windows.Forms.Label urunAdilbl;
        private System.Windows.Forms.Label urunKodulbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Msuteri_Sil_Button;
        private System.Windows.Forms.Label urunSillbl;
        private System.Windows.Forms.TextBox musterSiltextbox;
        private System.Windows.Forms.Button Ekle_button;
        private System.Windows.Forms.Label yeniUrunKodulbl;
        private System.Windows.Forms.TextBox yeniMusteriKoduText;
        private System.Windows.Forms.Label yeniUrunAdilbl;
        private System.Windows.Forms.TextBox yeniMsuteriAdiTextb;
        private System.Windows.Forms.Label yeniUrunStoklbl;
        private System.Windows.Forms.TextBox yenimMusteriStokMikText;
        private System.Windows.Forms.Label yeniUrunFiyat;
        private System.Windows.Forms.TextBox yeniMusteriFiyatText;
        private System.Windows.Forms.Button GuncelleButton;
        private System.Windows.Forms.TextBox yeniMusteriFiyat;
        private System.Windows.Forms.Label label2;
    }
}

