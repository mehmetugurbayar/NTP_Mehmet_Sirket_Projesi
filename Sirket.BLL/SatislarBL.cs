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
  public  class SatislarBL
    {
        Helper hlp = new Helper(); //
        public bool Yapilan_Satis_Ekle(Satislar satislar)
        {
            try
            {

                SqlParameter[] p = {
                new SqlParameter("@satis_kod", satislar.Satis_kod),
                new SqlParameter("@tarih", satislar.Tarih),
                new SqlParameter("@musteri_id", satislar.Musteri_id),
                new SqlParameter("@personel_id", satislar.Personel_id)};
                return hlp.ExecuteNonQuery("Insert into Yapilan_Satislar values(@satis_kod,@tarih,@musteri_id,@personel_id) ", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
