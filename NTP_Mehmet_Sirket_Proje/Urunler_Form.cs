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
    public partial class Urunler_Form : Form
    {
        public Urunler_Form()
        {
            InitializeComponent();
        }

        private void Ekle_button_Click(object sender, EventArgs e)
        {
            UrunBL sirketBL = new UrunBL();
            Urunler urun = new Urunler();
            urun.Urun_kodu = urun_kodu_textbox.Text.Trim();
           
            urun.Urun_ad = urun_adi_textbox.Text.Trim();
            urun.Fiyat = int.Parse(urun_fiyat_textbox.Text);
            urun.Stok_mik = int.Parse(urun_stokMik_textbox.Text);
            sirketBL.Urun_Ekle(urun);

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
    }
}
