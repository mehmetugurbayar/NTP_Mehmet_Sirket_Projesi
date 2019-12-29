namespace NTP_Mehmet_Sirket_Proje
{
    partial class Giris_Form
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
            this.GirisButton = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.Cikis_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ PANELİ";
            // 
            // GirisButton
            // 
            this.GirisButton.BackColor = System.Drawing.Color.CadetBlue;
            this.GirisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GirisButton.Location = new System.Drawing.Point(36, 145);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(300, 38);
            this.GirisButton.TabIndex = 3;
            this.GirisButton.Text = "GİRİŞ";
            this.GirisButton.UseVisualStyleBackColor = false;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // idTxt
            // 
            this.idTxt.BackColor = System.Drawing.Color.White;
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idTxt.ForeColor = System.Drawing.Color.Black;
            this.idTxt.Location = new System.Drawing.Point(36, 74);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(300, 26);
            this.idTxt.TabIndex = 4;
            this.idTxt.Text = "Kullanıcı ID";
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.Location = new System.Drawing.Point(36, 110);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(300, 26);
            this.sifreTxt.TabIndex = 5;
            this.sifreTxt.Text = "Sifre";
            // 
            // Cikis_Button
            // 
            this.Cikis_Button.BackColor = System.Drawing.Color.CadetBlue;
            this.Cikis_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikis_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikis_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cikis_Button.Location = new System.Drawing.Point(36, 189);
            this.Cikis_Button.Name = "Cikis_Button";
            this.Cikis_Button.Size = new System.Drawing.Size(300, 34);
            this.Cikis_Button.TabIndex = 6;
            this.Cikis_Button.Text = "ÇIKIŞ";
            this.Cikis_Button.UseVisualStyleBackColor = false;
            this.Cikis_Button.Click += new System.EventHandler(this.Cikis_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 56);
            this.panel1.TabIndex = 7;
            // 
            // Giris_Form
            // 
            this.AcceptButton = this.GirisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 247);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cikis_Button);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.GirisButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris_Form";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Giris_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.Button Cikis_Button;
        public System.Windows.Forms.TextBox idTxt;
        public System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Panel panel1;
    }
}