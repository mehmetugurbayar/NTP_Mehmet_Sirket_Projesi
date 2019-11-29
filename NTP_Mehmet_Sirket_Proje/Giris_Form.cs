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

        private void GirisButton_Click(object sender, EventArgs e)
        {
            //sql de tablo yap yöneticiler diye ordaki bilgilerle eşleşirse giriş yapılsın

            //combobox ile seç giriş türünü
            //rastgele kod versin timer tetiklensin belirtilen sürede kod girilsin


            GirisBL girisbl = new GirisBL();
            Giris giris = new Giris();
            giris.Yetki = int.Parse(yetkitxt.Text);
            giris.Kullanici_ad = idTxt.Text;
            giris.Kullanici_sifre = sifreTxt.Text;
            girisbl.Giris_Kontrol(giris);

            if (giris.Yetki== int.Parse(yetkitxt.Text) && giris.Kullanici_ad==idTxt.Text && giris.Kullanici_sifre==sifreTxt.Text)
            {

                MessageBox.Show("giriş.yapıldı");
            }
            else
            {

                MessageBox.Show("Böyle bir kullanıcı bulunamadı");

                //yönetici ise yönetici girişi yapıldı desin

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
