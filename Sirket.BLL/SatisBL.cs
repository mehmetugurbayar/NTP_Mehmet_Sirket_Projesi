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
    public class SatisBL
    {

        Helper hlp = new Helper(); 
        public bool Satis_Ekle(Satis satis)
        {
            try
            {

                SqlParameter[] p = {
                new SqlParameter("@satis_kod", satis.Satis_kod),
                new SqlParameter("@tarih", satis.Tarih),
                new SqlParameter("@musteri_id", satis.Musteri_id),
                new SqlParameter("@personel_id", satis.Personel_id),
                new SqlParameter("@urun_id", satis.Urun_id),

                new SqlParameter("@satis_adet", satis.Satilan_adet),
                new SqlParameter("@fiyat", satis.Fiyat)

            };
                return hlp.ExecuteNonQuery("Insert into Satis_Zaman_Tablosu values(@satis_kod,@tarih,@musteri_id,@personel_id,@urun_id,@satis_adet,@fiyat) ", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool Satis_Sil(Satis satis)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@satis_kod", satis.Satis_kod) };
                return hlp.ExecuteNonQuery("Delete from Satis_Tablous where satis_kod=@satis_kod", p) > 0;
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
