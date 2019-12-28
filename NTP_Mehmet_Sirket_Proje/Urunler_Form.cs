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
            dgv1.AutoGenerateColumns = false;
        }
        DataTable dt;

        int urun_counter = 0, silinen_urun_counter = 0;
        private void Ekle_button_Click(object sender, EventArgs e)
        {
            #region KatmanliVeriGonderme
            //UrunBL urunbl = new UrunBL();
            //try
            //{

            //    Urun urun = new Urun();
            //    urun.Urun_kodu = urun_kodu_textbox.Text.Trim();
            //    urun.Urun_ad = urun_adi_textbox.Text.Trim();
            //    urun.Fiyat = int.Parse(urun_fiyat_textbox.Text);
            //    urun.Stok_mik = int.Parse(urun_stokMik_textbox.Text);

            //    if (urunbl.Urun_Ekle(urun))
            //    {
            //        urun_counter++;
            //        urun_counter_lbl.Text = urun_counter + " Yeni Ürün Eklendi";


            //    }
            //    else
            //    {
            //        MessageBox.Show("Bir Hata Oluştu");

            //    }


            //}
            //catch (SqlException ex)
            //{
            //    switch (ex.Number)
            //    {
            //        default:
            //            MessageBox.Show("Veritabanı hatası!" + ex.Number);
            //            break;
            //    }

            //}
            //finally
            //{
            //    Temizle();
            //    urunbl.Dispose();
            //}

            #endregion

            #region EntityDBFirst
            try
            {
                Urun_Ekleyici();
                urun_counter++;
                urun_counter_lbl.Text = urun_counter + " Yeni Ürün Eklendi";

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Temizle();
                //dispose edemedim
            } 
            #endregion

        }

        private void GuncelleButton_Click(object sender, EventArgs e)
        {
            #region KatmanliGuncelle
            UrunBL urunbl = new UrunBL();
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
            #endregion

            #region EntityDatabaseFirst
            using (SirketContext sctx = new SirketContext())
            {
                Urun_Tablosu tablo = sctx.Urun_Tablosu.Find(Convert.ToInt32(yeniUrunKoduText.Text));
                tablo.urun_ad = yeniUrunAdiTextb.Text;
                tablo.fiyat = Convert.ToInt32(yeniUrunFiyatText.Text);
                tablo.stok_mik = Convert.ToInt32(yeniUrunStokMikText.Text);
                sctx.SaveChanges();
            } 
            #endregion

        }




        private void Urun_Sil_Button_Click(object sender, EventArgs e)
        {
            #region KatmanliSil
            //UrunBL urunbl = new UrunBL();
            //DialogResult dialog = MessageBox.Show("Silinsinmi", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            //if (dialog == DialogResult.No) return;
            //try
            //{

            //    Urun urun = new Urun();
            //    urun.Urun_kodu = urunSiltextbox.Text;
            //    if (urunbl.Urun_Sil(urun))
            //    {
            //        silinen_urun_counter++;
            //        lblSilmeSonuc.Text = silinen_urun_counter.ToString() + " Ürün Silindi";
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    Temizle();
            //    urunbl.Dispose();
            //} 
            #endregion

            using (SirketContext ctx = new SirketContext())
            {

                ctx.Urun_Tablosu.Remove(ctx.Urun_Tablosu.Find(int.Parse(urunSiltextbox.Text)));

                
                ctx.SaveChanges();

            }


        }

        private void URUN_ARA_BUTTON_Click(object sender, EventArgs e)
        {
           using (SirketContext ctx = new SirketContext())
            {
                
                Urun_Tablosu urun = ctx.Urun_Tablosu.Find(Convert.ToInt32( urunAraTextbox.Text)); //keyvalues integer olmalı


                
                List<Urun_Tablosu> lst = ctx.Urun_Tablosu.ToList();
                
                
                foreach (Urun_Tablosu uruns in lst)
                {
                    yeniUrunKoduText.Text = uruns.urun_kodu.ToString();
                    yeniUrunAdiTextb.Text = uruns.urun_ad.ToString();
                    yeniUrunStokMikText.Text = uruns.stok_mik.ToString();
                    yeniUrunFiyatText.Text = uruns.fiyat.ToString();
                }
                   ctx.SaveChanges();
                
            }
           

            #region KatmanliAra
            //UrunBL urunbl = new UrunBL();
            //try
            //{
            //    Urun urun = urunbl.Urun_Ara(urunAraTextbox.Text);



            //    if (urun == null)
            //    {
            //        MessageBox.Show("Böyle bir ürün bulunamadı.");
            //    }
            //    else
            //    {
            //        yeniUrunKoduText.Text = urun.Urun_kodu.ToString();
            //        yeniUrunAdiTextb.Text = urun.Urun_ad.ToString();
            //        yeniUrunStokMikText.Text = urun.Stok_mik.ToString();
            //        yeniUrunFiyatText.Text = urun.Fiyat.ToString();
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    Temizle();
            //    urunbl.Dispose();
            //} 
            #endregion


        }

        private void Urunler_Form_Load(object sender, EventArgs e)
        {
            UrunBL urunGoster = new UrunBL();
            dt = urunGoster.Urun_Tablo();
            dgv1.DataSource = dt;
            urunGoster.Dispose();


        }
        void Urun_Ekleyici()
        {
            using (SirketContext sctx = new SirketContext())
            {
                sctx.Urun_Tablosu.Add(new Urun_Tablosu
                {
                    urun_kodu = urun_kodu_textbox.Text.Trim(),
                    urun_ad = urun_adi_textbox.Text.Trim(),
                    fiyat = Convert.ToInt32(urun_fiyat_textbox.Text),
                    stok_mik = Convert.ToInt32(urun_stokMik_textbox.Text)
                });
                sctx.SaveChanges();
            }

        }
        private void tblKaydetButton_Click(object sender, EventArgs e)
        {
            #region TBLDeğişiki
            UrunBL urunGoster = new UrunBL();
            foreach (DataRow item in dt.Rows)
            {

                Urun urun = new Urun();
                if (item.RowState != DataRowState.Deleted)
                {
                    urun.Urun_kodu = item[0].ToString();
                    urun.Urun_ad = item[1].ToString();
                    urun.Stok_mik = Convert.ToInt32(item[2]);
                    urun.Fiyat = Convert.ToInt32(item[3]);

                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        urunGoster.Urun_Ekle(urun);
                        break;

                    case DataRowState.Modified:
                        urun.Urun_kodu = item[0].ToString();
                        urunGoster.Urun_Guncelle(urun);
                        break;
                    default:
                        break;
                }
            }

            #endregion
            #region EntityTabloDegisiklik
            //using (SirketContext sctx = new SirketContext())
            //{
            //    List<Urun_Tablosu> lst = sctx.Urun_Tablosu.ToList();
            //    foreach (Urun_Tablosu item in lst)
            //    {

            //        foreach (DataRow tbl in dt.Rows)
            //        {
            //            switch (tbl.RowState)
            //            {

            //                case DataRowState.Added:
            //                    Urun_Ekleyici();
            //                    break;
            //                case DataRowState.Deleted:
            //                    break;
            //                case DataRowState.Modified:
            //                    break;
            //                default:
            //                    break;
            //            }
            //        }
            //    }
            //}

            #endregion

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

        private void dgv1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete) //tablonun delete işlemi kapalı 
            {
                e.Handled = true;
                MessageBox.Show("Güvenlik için tablodan bu şekilde silme işlemi gerçekleştiremezsiniz. Lütfen silme panelinden işlem yapın.", "UYARI");
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
