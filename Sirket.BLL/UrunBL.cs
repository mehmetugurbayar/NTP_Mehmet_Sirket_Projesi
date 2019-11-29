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
    public class UrunBL:IDisposable
    {
        Helper hlp = new Helper();
        public bool Urun_Ekle(Urun urun)
        {

            SqlParameter[] p = { new SqlParameter("@urun_kodu", urun.Urun_kodu), new SqlParameter("@urun_ad", urun.Urun_ad), new SqlParameter("@stok_mik", urun.Stok_mik), new SqlParameter("@fiyat", urun.Fiyat) };
            return hlp.ExecuteNonQuery("Insert into Urun_Tablosu values(@urun_kodu,@urun_ad,@stok_mik,@fiyat)", p) > 0; /*executenonquery int türünde olduğu için dönülen değerin bool şartı taşıması için 0 dan büyüklüğne bakarız*/
        }
        public bool Urun_Guncelle(Urun urun)
        {
            SqlParameter[] p = { new SqlParameter("@urun_kodu", urun.Urun_kodu), new SqlParameter("@urun_ad", urun.Urun_ad), new SqlParameter("@stok_mik", urun.Stok_mik), new SqlParameter("@fiyat", urun.Fiyat) };
            return hlp.ExecuteNonQuery("UPDATE Urun_Tablosu SET urun_kodu=@urun_kodu, urun_ad=@urun_ad,stok_mik=@stok_mik,fiyat=@fiyat WHERE urun_kodu=@urun_kodu", p) > 0;


        }
        public bool Urun_Sil(Urun urun)
        {
            SqlParameter[] p = { new SqlParameter("@urun_kodu", urun.Urun_kodu) };
            return hlp.ExecuteNonQuery("Delete from Urun_Tablosu where urun_kodu=@urun_kodu", p) > 0;

        }
        public Urun Urun_Ara(string urunKodu)
        {
            Urun urun = null;
            SqlParameter[] p = { new SqlParameter("@urun_kodu", urunKodu) };
            SqlDataReader dr = hlp.ExecuteReader("Select urun_kodu,urun_ad,stok_mik,fiyat from Urun_Tablosu where urun_kodu=@urun_kodu", p);
            
            if (dr.Read())
            {
                urun = new Urun();
                urun.Urun_kodu = dr["urun_kodu"].ToString();
                urun.Urun_ad = dr["urun_ad"].ToString();
                urun.Stok_mik = Convert.ToInt32(dr["stok_mik"]);
                urun.Fiyat = Convert.ToInt32(dr["fiyat"]);

            }
            dr.Close();
            return urun;

        }

        public void Veri_Getir()
        {
            Helper connect = new Helper();
           // SqlDataAdapter da;
            //da = new SqlDataAdapter("SELECT *FROM Urun_Tablosu", );
        }

        public void Dispose()
        {
            hlp.Dispose();
        }
    }
}
