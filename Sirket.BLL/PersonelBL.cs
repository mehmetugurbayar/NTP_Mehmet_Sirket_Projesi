using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sirket.DAL;
using Sirket.MODEL;

namespace Sirket.BLL
{
    public class PersonelBL : IDisposable
    {
        Helper hlp = new Helper();
        public bool Personel_Ekle(Personel personel)
        {

            try
            {
                SqlParameter[] p = {
                new SqlParameter("@perso_kod", personel.Perso_kod),
                new SqlParameter("@perso_ad", personel.Perso_ad),
                new SqlParameter("@perso_soyad", personel.Perso_soyad),
                new SqlParameter("@perso_cinsiyet", personel.Perso_cinsiyet),
                new SqlParameter("@tel", personel.Tel),
                new SqlParameter("@mail", personel.Mail),
                new SqlParameter("@dogum_tarih", personel.Dogum_tarihi),
                new SqlParameter("@dogum_yeri", personel.Dogum_yeri),
                new SqlParameter("@unvan", personel.Unvan),
                new SqlParameter("@maas", personel.Maas),
                new SqlParameter("@pozisyon", personel.Pozisyon),
                new SqlParameter("@baslama_tarih", personel.Baslama_tarihi)

            };
                return hlp.ExecuteNonQuery("Insert into Personel_Tablosu values(@perso_kod,@perso_ad,@perso_soyad,@perso_cinsiyet,@tel,@mail,@dogum_tarih,@dogum_yeri,@unvan,@maas,@pozisyon,@baslama_tarih) ", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Personel_Guncelle(Personel personel)
        {
            try
            {
                SqlParameter[] p = {
                new SqlParameter("@perso_kod", personel.Perso_kod),
                new SqlParameter("@perso_ad", personel.Perso_ad),
                new SqlParameter("@perso_soyad", personel.Perso_soyad),
                new SqlParameter("@perso_cinsiyet", personel.Perso_cinsiyet),
                new SqlParameter("@tel", personel.Tel),
                new SqlParameter("@mail", personel.Mail),
                new SqlParameter("@dogum_tarih", personel.Dogum_tarihi),
                new SqlParameter("@dogum_yeri", personel.Dogum_yeri),
                new SqlParameter("@unvan", personel.Unvan),
                new SqlParameter("@maas", personel.Maas),
                new SqlParameter("@pozisyon", personel.Pozisyon),
                new SqlParameter("@baslama_tarih", personel.Baslama_tarihi), };
                return hlp.ExecuteNonQuery("UPDATE Personel_Tablosu SET perso_ad=@perso_ad,perso_soyad=@perso_soyad,perso_cinsiyet=@perso_cinsiyet,tel=@tel,mail=@mail,dogum_tarih=@dogum_tarih,dogum_yeri=@dogum_yeri,unvan=@unvan,maas=@maas,pozisyon=@pozisyon,baslama_tarih=@baslama_tarih  WHERE perso_kod=@perso_kod", p) > 0;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable Personel_Tablo() => hlp.TabloGetir("Select perso_kod,perso_ad,perso_soyad,perso_cinsiyet,tel,mail,dogum_tarih,dogum_yeri,unvan,maas,pozisyon,baslama_tarih from Personel_Tablosu  ");
        
        public bool Personel_Sil(Personel personel)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@perso_kod", personel.Perso_kod) };
                return hlp.ExecuteNonQuery("Delete from Personel_Tablosu where perso_kod=@perso_kod", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Personel Personel_Ara(int girilen_personel_kodu)
        {

            try
            { Personel personel = null;
                SqlParameter[] p = { new SqlParameter("@perso_kod", girilen_personel_kodu) };
                SqlDataReader dr = hlp.ExecuteReader("Select perso_kod,perso_ad,perso_soyad,perso_cinsiyet,tel,mail,dogum_tarih,dogum_yeri,unvan,maas,pozisyon,baslama_tarih from Personel_Tablosu where perso_kod=@perso_kod", p);
               
                if (dr.Read())
                {
                    personel = new Personel();
                    personel.Perso_kod = Convert.ToInt32(dr["perso_kod"]);
                    personel.Perso_ad = dr["perso_ad"].ToString();
                    personel.Perso_soyad = dr["perso_soyad"].ToString();
                    personel.Perso_cinsiyet = dr["perso_cinsiyet"].ToString();
                    personel.Tel = dr["tel"].ToString();
                    personel.Mail = dr["mail"].ToString();
                    personel.Dogum_tarihi = dr["dogum_tarih"].ToString();
                    personel.Dogum_yeri = dr["dogum_yeri"].ToString();
                    personel.Unvan = dr["unvan"].ToString();
                    personel.Maas = Convert.ToInt32(dr["maas"]);
                    personel.Pozisyon = dr["pozisyon"].ToString();
                    personel.Baslama_tarihi = dr["baslama_tarih"].ToString();
                }
                dr.Close();
                return personel;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Dispose()
        {
            hlp.Dispose();
        }
    }
}
