namespace NTP_Mehmet_Sirket_Proje
{
    partial class Yapilan_Satislar_Form
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
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.satis_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satilan_adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.AllowUserToDeleteRows = false;
            this.dgvSatislar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satis_kod,
            this.urun_id,
            this.tarih,
            this.satilan_adet,
            this.fiyat});
            this.dgvSatislar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSatislar.Location = new System.Drawing.Point(0, 0);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.Size = new System.Drawing.Size(800, 450);
            this.dgvSatislar.TabIndex = 0;
            // 
            // satis_kod
            // 
            this.satis_kod.DataPropertyName = "satis_kod";
            this.satis_kod.HeaderText = "Satış Kodu";
            this.satis_kod.Name = "satis_kod";
            this.satis_kod.ReadOnly = true;
            // 
            // urun_id
            // 
            this.urun_id.DataPropertyName = "urun_ad";
            this.urun_id.HeaderText = "Satılan Ürün";
            this.urun_id.Name = "urun_id";
            this.urun_id.ReadOnly = true;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            // 
            // satilan_adet
            // 
            this.satilan_adet.DataPropertyName = "satilan_adet";
            this.satilan_adet.HeaderText = "Satış Miktarı";
            this.satilan_adet.Name = "satilan_adet";
            this.satilan_adet.ReadOnly = true;
            // 
            // fiyat
            // 
            this.fiyat.DataPropertyName = "fiyat";
            this.fiyat.HeaderText = "Tutar";
            this.fiyat.Name = "fiyat";
            this.fiyat.ReadOnly = true;
            // 
            // Yapilan_Satislar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSatislar);
            this.Name = "Yapilan_Satislar_Form";
            this.Text = "Yapilan_Satislar_Form";
            this.Load += new System.EventHandler(this.Yapilan_Satislar_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.DataGridViewTextBoxColumn satis_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn satilan_adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
    }
}