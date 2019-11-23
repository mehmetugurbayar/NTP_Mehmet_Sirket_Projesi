using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Mehmet_Sirket_Proje
{
    public partial class Giris_Form : Form
    {
        public Giris_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            //sql de tablo yap yöneticiler diye ordaki bilgilerle eşleşirse giriş yapılsın

            //combobox ile seç giriş türünü

            this.Enabled = false;

        }

        private void Cikis_Button_Click(object sender, EventArgs e)
        {//kapanması gereken diper şwyleride kapat
           
            Application.Exit();
        }
    }
}
