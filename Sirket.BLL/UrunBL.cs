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
    public class UrunBL
    {
        Helper hlp = new Helper();
        public bool Urun_Ekle(Urunler urun)
        {
           
           SqlParameter[] p = {new SqlParameter("@urun_kodu", urun.Urun_kodu), new SqlParameter("@urun_ad", urun.Urun_ad), new SqlParameter("@stok_mik", urun.Stok_mik), new SqlParameter("@fiyat", urun.Fiyat) };
            return hlp.ExecuteNonQuery("Insert into Urun_Tablosu values(@urun_kodu,@urun_ad,@stok_mik,@fiyat)", p) > 0; /*executenonquery int türünde olduğu için dönülen değerin bool şartı taşıması için 0 dan büyüklüğne bakarız*/
        }
        public bool Urun_Guncelle(Urunler urun)
        {
            SqlParameter[] p = { new SqlParameter("@urun_kodu", urun.Urun_kodu), new SqlParameter("@urun_ad", urun.Urun_ad), new SqlParameter("@stok_mik", urun.Stok_mik), new SqlParameter("@fiyat", urun.Fiyat) };
            return hlp.ExecuteNonQuery("UPDATE Urun_Tablosu SET urun_kodu=@urun_kodu, urun_ad=@urun_ad,stok_mik=@stok_mik,fiyat=@fiyat WHERE urun_kodu=@urun_kodu", p) > 0 ;

            
        }
        
    }
}
