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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GirisButton = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.Cikis_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE";
            // 
            // GirisButton
            // 
            this.GirisButton.Location = new System.Drawing.Point(116, 133);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(100, 23);
            this.GirisButton.TabIndex = 3;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // idTxt
            // 
            this.idTxt.BackColor = System.Drawing.Color.White;
            this.idTxt.ForeColor = System.Drawing.Color.Black;
            this.idTxt.Location = new System.Drawing.Point(116, 61);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 20);
            this.idTxt.TabIndex = 4;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(116, 96);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(100, 20);
            this.sifreTxt.TabIndex = 5;
            // 
            // Cikis_Button
            // 
            this.Cikis_Button.Location = new System.Drawing.Point(116, 164);
            this.Cikis_Button.Name = "Cikis_Button";
            this.Cikis_Button.Size = new System.Drawing.Size(100, 23);
            this.Cikis_Button.TabIndex = 6;
            this.Cikis_Button.Text = "ÇIKIŞ";
            this.Cikis_Button.UseVisualStyleBackColor = true;
            this.Cikis_Button.Click += new System.EventHandler(this.Cikis_Button_Click);
            // 
            // Giris_Form
            // 
            this.AcceptButton = this.GirisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 233);
            this.Controls.Add(this.Cikis_Button);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Giris_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris_Form";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Giris_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.Button Cikis_Button;
        public System.Windows.Forms.TextBox idTxt;
        public System.Windows.Forms.TextBox sifreTxt;
    }
}