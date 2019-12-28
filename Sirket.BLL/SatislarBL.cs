using Sirket.DAL;
using Sirket.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.BLL
{
  public  class SatislarBL:IDisposable
    {
        Helper hlp = new Helper(); 

        public DataTable Satislar_Tablosu() => hlp.TabloGetir("Select satis.satis_kod, urun.urun_ad, satis.tarih ,satis.satilan_adet ,satis.fiyat from Satis_Tablosu satis , Urun_Tablosu urun");




        public void Dispose()
        {
            hlp.Dispose();
        }
    }
}
