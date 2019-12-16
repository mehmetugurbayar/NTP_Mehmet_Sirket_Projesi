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
    public partial class Personel_Form : Form
    {
        public Personel_Form()
        {
            InitializeComponent();
            dgvPersonel.AutoGenerateColumns = false;
            //eğer güncelleme alanına yazı yazılırsa ekle butonu güncelle butonuna dönsün
        }

        DataTable dt;

        private void Personel_Ekle_Button_Click(object sender, EventArgs e)
        {
            PersonelBL personelbl = new PersonelBL();
            try
            {
                Personel personel = new Personel();
                personel.Perso_kod = int.Parse(txtKod.Text);
                personel.Perso_ad = txtAd.Text.Trim();
                personel.Perso_soyad = txtSoyad.Text.Trim();
                personel.Perso_cinsiyet = cmboxCinsiyet.SelectedText;
                personel.Tel = txtTel.Text.Trim();
                personel.Mail = txtMail.Text.Trim();
                personel.Dogum_tarihi = txtDoTarihi.Text.Trim();
                personel.Dogum_yeri = txtDoYeri.Text.Trim();
                personel.Unvan = txtUnvan.Text.Trim();
                personel.Maas = int.Parse(txtMaas.Text);
                personel.Pozisyon = txtPzsyn.Text.Trim();
                personel.Baslama_tarihi = txtBaslaTarihi.Text.Trim();
                if (personelbl.Personel_Ekle(personel))
                {
                    MessageBox.Show("personel eklendi");
                }
                else
                {
                    MessageBox.Show("Personel eklenirken bir hata oluştu");
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                //temizle metotu gelsin
                personelbl.Dispose();
            }

        }

        private void Kayit_Sil_Click(object sender, EventArgs e)
        {
            //msg box ile güvenlik için şifreyi tekrar girdircek sonra silme yapılcak
          
            
            PersonelBL personelbl = new PersonelBL();
            DialogResult dialog = MessageBox.Show("Silinsinmi", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (dialog == DialogResult.No) return;
            try
            {

                Personel personel = new Personel();
                personel.Perso_kod = int.Parse(txtPerso_Sil.Text);
                if (personelbl.Personel_Sil(personel))
                {
                    MessageBox.Show("personel silindi");

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                personelbl.Dispose();
            }
        }

        private void PersonelAraButton_Click(object sender, EventArgs e)
        {
            lblGuncelleUyari.Text = "Uyarı: Personel Kodunu Güncelleyemezsiniz.";
            Personel_Ekle_Button.Visible = false;
            GuncelleButton.Visible = true;
            txtKod.Enabled = false; // personel kodunda güncelleme yapılmaz çünkü identity
            PersonelBL personelbl = new PersonelBL();
           
            
            try
            {
               
                
                Personel personel = personelbl.Personel_Ara(int.Parse(txtGuncellePKodu.Text));


                if (personel == null)
                {
                    MessageBox.Show("Böyle bir personel bulunamadı.");
                }
                else
                {
                    txtKod.Text = personel.Perso_kod.ToString();
                    txtAd.Text = personel.Perso_ad.ToString();
                    txtSoyad.Text = personel.Perso_soyad.ToString();
                    txtCinsiyet.Text = personel.Perso_cinsiyet.ToString();
                    txtTel.Text = personel.Tel.ToString();
                    txtMail.Text = personel.Mail.ToString();
                    txtDoTarihi.Text = personel.Dogum_tarihi.ToString();
                    txtDoYeri.Text = personel.Dogum_yeri.ToString();
                    txtUnvan.Text = personel.Unvan.ToString();
                    txtMaas.Text = personel.Maas.ToString();
                    txtPzsyn.Text = personel.Pozisyon.ToString();
                    txtBaslaTarihi.Text = personel.Baslama_tarihi.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //Temizle();
                personelbl.Dispose();
            }
        }

        private void GuncelleButton_Click(object sender, EventArgs e)
        {
           
            PersonelBL personelbl = new PersonelBL();
            try
            {
                


                Personel personel = new Personel();
                personel.Perso_kod = int.Parse(txtKod.Text);
                personel.Perso_ad = txtAd.Text.Trim();
                personel.Perso_soyad = txtSoyad.Text.Trim();
                personel.Perso_cinsiyet = txtCinsiyet.Text.Trim();
                personel.Tel = txtTel.Text.Trim();
                personel.Mail = txtMail.Text.Trim();
                personel.Dogum_tarihi = txtDoTarihi.Text.Trim();
                personel.Dogum_yeri = txtDoYeri.Text.Trim();
                personel.Unvan = txtUnvan.Text.Trim();
                personel.Maas = int.Parse(txtMaas.Text);
                personel.Pozisyon = txtPzsyn.Text.Trim();
                personel.Baslama_tarihi = txtBaslaTarihi.Text.Trim();
                if (personelbl.Personel_Guncelle(personel))
                {
                    MessageBox.Show("personel eklendi");
                }
                else
                {
                    MessageBox.Show("Personel eklenirken bir hata oluştu");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Temizle();
                personelbl.Dispose();
            }
        }

        void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                item.Text = string.Empty;
            }



        }
      
        private void Personel_Form_Load(object sender, EventArgs e)
        {
            PersonelBL personelGoster= new PersonelBL();
            dt = personelGoster.Personel_Tablo();
            dgvPersonel.DataSource = dt;
        }

        private void tblKaydetBtn_Click(object sender, EventArgs e)
        {
            PersonelBL personelGoster = new PersonelBL();
            foreach (DataRow item in dt.Rows)
            {

                Personel personel = new Personel();
                if (item.RowState != DataRowState.Deleted)
                {
                    //personel.Perso_kod = item[0].ToString();
                    personel.Perso_ad= item[1].ToString();
                    personel.Perso_soyad = item[2].ToString();
                    personel.Perso_cinsiyet = item[3].ToString();
                    personel.Tel = item[4].ToString();
                    personel.Mail= item[5].ToString();
                    personel.Dogum_tarihi= item[6].ToString();
                    personel.Dogum_yeri = item[7].ToString();
                    personel.Unvan = item[8].ToString();
                    personel.Maas= Convert.ToInt32(item[9]);
                    personel.Pozisyon = item[10].ToString();
                    personel.Baslama_tarihi = item[11].ToString();
                    
                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        personelGoster.Personel_Ekle(personel);
                        break;

                    case DataRowState.Modified:
                        personel.Perso_kod = Convert.ToInt32( item[0]);
                        personelGoster.Personel_Guncelle(personel);
                        break;
                    default:
                        break;
                }
            }

        }

        private void Personel_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete) //tablonun delete işlemi kapalı 
            {
                e.Handled = true;
                MessageBox.Show("Güvenlik için tablodan bu şekilde silme işlemi gerçekleştiremezsiniz. Lütfen silme panelinden işlem yapın.", "UYARI");
            }
        }
    }
}
