using Sirket.DAL;
using Sirket.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.BLL
{
  public  class MusteriBL
    {
        Helper hlp = new Helper();
        public bool Musteri_Ekle(Musteri musteri) //TRY CATCH EKLEEEEEEEEEEEEE
        {
            try
            {

                SqlParameter[] p = {
                new SqlParameter("@musteri_kod", musteri.Musteri_kod),
                new SqlParameter("@musteri_ad", musteri.Musteri_ad),
                new SqlParameter("@musteri_soyad", musteri.Musteri_soyad),
                new SqlParameter("@tel", musteri.Tel),
                new SqlParameter("@adres", musteri.Adres)

            };
                return hlp.ExecuteNonQuery("Insert into Musteri_Tablosu values(@musteri_kod,@musteri_ad,@musteri_soyad,@tel,@adres) ", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Musteri_Guncelle(Musteri musteri) 
        {

            try
            {
                SqlParameter[] p = {
                new SqlParameter("@musteri_kod", musteri.Musteri_kod),
                new SqlParameter("@musteri_ad", musteri.Musteri_ad),
                new SqlParameter("@musteri_soyad", musteri.Musteri_soyad),
                new SqlParameter("@tel", musteri.Tel),
                new SqlParameter("@adres", musteri.Adres),

            };
                return hlp.ExecuteNonQuery("Update Musteri_Tablosu SET @musteri_kod,@musteri_ad,@musteri_soyad,@tel,@adres where musteri_kod=@musteri_kod", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Musteri_Sil(Musteri musteri)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@musteri_kod", musteri.Musteri_kod) };
                return hlp.ExecuteNonQuery("Delete from Musteri_Tablosu where musteri_kod=@musteri_kod", p) > 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public Musteri Musteri_Ara(int girilen_musteri_kodu)
        {
            try
            {

                SqlParameter[] p = { new SqlParameter("@musteri_kod", girilen_musteri_kodu) };
                SqlDataReader dr = hlp.ExecuteReader("Select @musteri_kod,@musteri_ad,@musteri_soyad,@tel,@adres from Musteri_Tablosu where musteri_kod=@musteri_kod", p);
                Musteri musteri = null;
                if (dr.Read())
                {
                    musteri = new Musteri();
                    musteri.Musteri_kod = Convert.ToInt32(dr["musteri_kod"]);
                    musteri.Musteri_ad = dr["musteri_ad"].ToString();
                    musteri.Musteri_soyad = dr["musteri_soyad"].ToString();
                    musteri.Tel = dr["tel"].ToString();
                    musteri.Adres = dr["adres"].ToString();

                }
                dr.Close();
                return musteri;
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

