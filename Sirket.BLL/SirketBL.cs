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
    public class SirketBL
    {
        public bool Urun_Ekle(Urunler urun)
        {
            Helper hlp = new Helper();
            SqlParameter[] p = {new SqlParameter("@urun_kodu", urun.Urun_kodu), new SqlParameter("@urun_ad", urun.Urun_ad), new SqlParameter("@stok_mik", urun.Stok_mik), new SqlParameter("@fiyat", urun.Fiyat) };
            return hlp.ExecuteNonQuery("Insert into Urun_Tablosu values(@urun_kodu,@urun_ad,@stok_mik,@fiyat)", p) > 0; /*executenonquery int türünde olduğu için dönülen değerin bool şartı taşıması için 0 dan büyüklüğne bakarız*/
        }
    }
}
