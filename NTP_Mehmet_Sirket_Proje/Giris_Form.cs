using Sirket.BLL;
using Sirket.MODEL;
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

        string ad, sifre;
        int yetki;
        private void GirisButton_Click(object sender, EventArgs e)
        {
         

            //combobox ile seç giriş türünü
            //rastgele kod versin timer tetiklensin belirtilen sürede kod girilsin


            GirisBL girisbl = new GirisBL();
            Giris giris = new Giris();
            yetki= int.Parse(yetkitxt.Text);
            ad = idTxt.Text;
            sifre= sifreTxt.Text;
            girisbl.Giris_Kontrol(yetki,ad,sifre);

            if (giris.Yetki== yetki && giris.Kullanici_ad==ad && giris.Kullanici_sifre==sifre)
            {

                MessageBox.Show("giriş.yapıldı");
                //yönetici ise yönetici girişi yapıldı desin
            }
            else
            {

                MessageBox.Show("Böyle bir kullanıcı bulunamadı");

              

            }

            /*
        giris.Yetki= girisbl.Giris_Kontrol().Yetki;
        giris.Kullanici_ad= girisbl.Giris_Kontrol().Kullanici_ad;
        giris.Kullanici_sifre = girisbl.Giris_Kontrol().Kullanici_sifre;
        //veritabanından alınan bilgiler
        */


            //this.Enabled = false;

        }

        private void Cikis_Button_Click(object sender, EventArgs e)
        {//kapanması gereken diper şwyleride kapat

            Application.Exit();
        }
    }
}
