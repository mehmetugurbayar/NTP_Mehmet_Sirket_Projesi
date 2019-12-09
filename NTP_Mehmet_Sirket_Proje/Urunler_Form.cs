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

        int urun_counter=0,silinen_urun_counter=0;
        private void Ekle_button_Click(object sender, EventArgs e)
        { UrunBL urunbl = new UrunBL();
            try
            {
           
            Urun urun = new Urun();
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
        { UrunBL urunbl = new UrunBL();
            try
            {
               
                Urun urun = new Urun();
                urun.Urun_kodu = yeniUrunKoduText.Text.Trim();
                urun.Urun_ad = yeniUrunAdiTextb.Text.Trim();
                urun.Stok_mik = int.Parse(yeniUrunStokMikText.Text);
                urun.Fiyat = int.Parse(yeniUrunFiyatText.Text);
                urunbl.Urun_Guncelle(urun);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu");

            }
            finally
            {
                Temizle();
                urunbl.Dispose();
            }


        }

        private void Urun_Sil_Button_Click(object sender, EventArgs e)
        {UrunBL urunbl = new UrunBL();
            DialogResult dialog = MessageBox.Show("Silinsinmi", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (dialog == DialogResult.No) return;
            try
            {
                
                Urun urun = new Urun();
                urun.Urun_kodu = urunSiltextbox.Text;
                if (urunbl.Urun_Sil(urun))
                { silinen_urun_counter++;
                    lblSilmeSonuc.Text =silinen_urun_counter.ToString()+" Ürün Silindi";
                } 
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Temizle();
                urunbl.Dispose();
            }
        }

        private void URUN_ARA_BUTTON_Click(object sender, EventArgs e)
        {UrunBL urunbl = new UrunBL();
            try
            {
                Urun urun = urunbl.Urun_Ara(urunAraTextbox.Text);



                if (urun == null)
                {
                    MessageBox.Show("Böyle bir ürün bulunamadı.");
                }
                else
                {
                    yeniUrunKoduText.Text = urun.Urun_kodu.ToString();
                    yeniUrunAdiTextb.Text = urun.Urun_ad.ToString();
                    yeniUrunStokMikText.Text = urun.Stok_mik.ToString();
                    yeniUrunFiyatText.Text = urun.Fiyat.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Temizle();
                urunbl.Dispose();
            }
        }

        private void Urunler_Form_Load(object sender, EventArgs e)
        {
            //TABLO OTOMATİK YÜKLENECEK
            UrunBL urunGoster = new UrunBL();
            DataTable tablo = new DataTable();
           // urunGoster.Veri_Getir();

          //  dataGridView1.DataSource = urunGoster.Veri_Getir(); 
            urunGoster.Dispose();

        }

        private void urun_adi_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar > 32 && (int)e.KeyChar < 65) || ((int)e.KeyChar > 90 && (int)e.KeyChar < 97) || (int)e.KeyChar > 122 && (int)e.KeyChar < 127)
            {
                e.Handled = true;
                MessageBox.Show("Ürün adı yalnızca harflerden oluşmaktadır");
            }
        }

        private void urun_stokMik_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar < 47 && (int)e.KeyChar > 58)
            {
                e.Handled = true;
                MessageBox.Show("Stok bilgisi rakamlardan oluşmalıdır");
            }
        }

        private void urun_fiyat_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar < 47 && (int)e.KeyChar > 57)
            {
                e.Handled = true;
                MessageBox.Show("Fiyat bilgisini sayısal olarak giriniz");
            }
        }

        void Temizle()
        {
            foreach (Control item in this.Controls["pnlEkle"].Controls)
            {
                item.Text = string.Empty;
            }
            foreach (Control item in this.Controls["pnlGuncelle"].Controls)
            {
                item.Text = string.Empty;
            }
            foreach (Control item in this.Controls["pnlSil"].Controls)
            {
                item.Text = string.Empty;
            }
            lblSilmeSonuc.Text = "";
            urun_counter_lbl.Text = "";

        }
    }
}
