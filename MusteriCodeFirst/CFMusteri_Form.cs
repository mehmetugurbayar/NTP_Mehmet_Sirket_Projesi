using CFDAL;
using CFMODELS;
using SrktCFBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriCodeFirst
{
    public partial class CFMusteri_Form : Form
    {
        public CFMusteri_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Ekle_button_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            try
            {
                musteri.Musteri_kod = txtmusteriKod.Text;
                musteri.Musteri_ad = txtmusteriAd.Text;
                musteri.Musteri_soyad = txtmusteriSoyad.Text;
                musteri.Tel = txtmusteriTel.Text;
                musteri.Adres = txtmusteriAdres.Text;

                MusteriBL mb = new MusteriBL();
                mb.MusteriEkle(musteri);
                mb.SaveChanges();

            }
            catch (Exception)
            {

                MessageBox.Show("Eklenemedi");
            }



        }

        private void Msuteri_Sil_Button_Click(object sender, EventArgs e)
        {
            Musteri mstr = new Musteri();
            MusteriBL mb = new MusteriBL();
            mstr.Musteri_kod = musterSiltextbox.Text;
            mb.MusteriSil(mstr);
            mb.SaveChanges();
        }
    }
}
