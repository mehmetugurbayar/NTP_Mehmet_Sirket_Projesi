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
    public partial class Urunler_Form : Form
    {
        public Urunler_Form()
        {
            InitializeComponent();
        }

        int urun_counter=0;
        private void Ekle_button_Click(object sender, EventArgs e)
        { UrunBL urunbl = new UrunBL();
            try
            {
           
            Urunler urun = new Urunler();
            urun.Urun_kodu = urun_kodu_textbox.Text.Trim();
           urun.Urun_ad = urun_adi_textbox.Text.Trim();
            urun.Fiyat = int.Parse(urun_fiyat_textbox.Text);
            urun.Stok_mik = int.Parse(urun_stokMik_textbox.Text);
            
                if (urunbl.Urun_Ekle(urun))
                {
                    urun_counter++;
                    urun_counter_lbl.Text = urun_counter + " Yeni Ürün Eklendi";


                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu");

                }
            
            
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    default:
                        MessageBox.Show("Veritabanı hatası!" + ex.Number);
                        break;
                }

            }
            finally
            {
                Temizle();
                urunbl.Dispose();
            }
            

        }

        private void GuncelleButton_Click(object sender, EventArgs e)
        {
            UrunBL urunbl = new UrunBL();
            Urunler urun = new Urunler();
            urun.Urun_kodu = yeniUrunKoduText.Text.Trim();
            urun.Urun_ad= yeniUrunAdiTextb.Text.Trim();
            urun.Stok_mik = int.Parse(yeniUrunStokMikText.Text);
            urun.Fiyat = int.Parse(yeniUrunFiyatText.Text);
            urunbl.Urun_Guncelle(urun);
            
        }

        private void Urun_Sil_Button_Click(object sender, EventArgs e)
        {
            UrunBL urunbl = new UrunBL();
            Urunler urun = new Urunler();
            urun.Urun_kodu = urunSiltextbox.Text;
            urunbl.Urun_Sil(urun);
        }

        private void URUN_ARA_BUTTON_Click(object sender, EventArgs e)
        {UrunBL urunbl = new UrunBL(); 
            Urunler urun = urunbl.Urun_Ara(urunAraTextbox.Text);



            if (urun==null)
            {
                MessageBox.Show("Böyle bir ürün bulunamadı.");
            }
            else
            {
               yeniUrunKoduText.Text = urun.Urun_kodu.ToString();
                yeniUrunAdiTextb.Text = urun.Urun_ad.ToString();
                yeniUrunStokMikText.Text = urun.Stok_mik.ToString();
                yeniUrunFiyatText.Text=urun.Fiyat.ToString();
            }
        }

        private void Urunler_Form_Load(object sender, EventArgs e)
        {
            //TABLO OTOMATİK YÜKLENECEK

        }
        void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                item.Text = string.Empty;
            }
           
        }
    }
}
