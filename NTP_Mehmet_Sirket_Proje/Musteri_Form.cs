using Sirket.BLL;
using Sirket.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Mehmet_Sirket_Proje
{
    public partial class Musteri_Form : Form
    {
        public Musteri_Form()
        {
            InitializeComponent();
        }

        private void Musteri_Form_Load(object sender, EventArgs e)
        {
          

        }

        private void MusteriKayitbtn_Click(object sender, EventArgs e)
        {


            MusteriBL mbl = new MusteriBL();
            try
            {
                Musteri mstr = new Musteri();
               
                Random rastgele = new Random();
                string harfler = "abcçdefgğhıijklmnoöprsştuüvyz";
                string uret = "";
                for (int i = 0; i < 6; i++)
                {
                    uret += harfler[rastgele.Next(harfler.Length)];
                }


                mstr.Musteri_kodu = uret;
                mstr.Musteri_ad = txtMusteriAd.Text.Trim();

                mstr.Musteri_soyad = txtMusteriSoyad.Text.Trim();
                mstr.Tel = txtTel.Text;
                mstr.Adres = txtMsuteriAdres.Text;
                if (mbl.Musteri_Ekle(mstr))
                {

                    MessageBox.Show("Müşteri Eklendi");


                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu");

                }


            }
            catch (Exception)
            {

                throw;



            }
            finally
            {
                // Temizle();

            }
        }

        private void MusteriArabtn_Click(object sender, EventArgs e)
        {
            MusteriKayitbtn.Visible = false;
            MusteriGuncellebtn.Visible = true;
            MusteriBL mbl = new MusteriBL();
            try
            {


                Musteri mstr = mbl.Musteri_Ara(txtMusteriAra.Text.Trim());


                if (mstr == null)
                {
                    MessageBox.Show("Böyle bir Müşteri bulunamadı.");
                }
                else
                {
                    txtMusteriAd.Text = mstr.Musteri_ad.ToString();
                    txtMusteriSoyad.Text = mstr.Musteri_soyad.ToString();
                    txtTel.Text = mstr.Tel.ToString();
                    txtMsuteriAdres.Text = mstr.Adres.ToString();

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //Temizle();
                // personelbl.Dispose();
            }
        }

        private void MusteriGuncellebtn_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar > 32 && (int)e.KeyChar < 65) || ((int)e.KeyChar > 90 && (int)e.KeyChar < 97) || (int)e.KeyChar > 122 && (int)e.KeyChar < 127)
            {
                e.Handled = true;
                MessageBox.Show("Ad yalnızca harflerden oluşmaktadır");
            }
        }

        private void txtMusteriSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar > 32 && (int)e.KeyChar < 65) || ((int)e.KeyChar > 90 && (int)e.KeyChar < 97) || (int)e.KeyChar > 122 && (int)e.KeyChar < 127)
            {
                e.Handled = true;
                MessageBox.Show("Soyad yalnızca harflerden oluşmaktadır");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

           
        }
    }
}
