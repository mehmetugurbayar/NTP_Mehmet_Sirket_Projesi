using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.MODEL
{
  public  class Satis //URUNLERLE CALIŞAN TABLONUN MODELİ
    {
        string tarih, satilan_adet;
        int satis_kod, urun_id, fiyat;

        public string Tarih { get => tarih; set => tarih = value; }
        public string Satilan_adet { get => satilan_adet; set => satilan_adet = value; }
        public int Satis_kod { get => satis_kod; set => satis_kod = value; }
        public int Urun_id { get => urun_id; set => urun_id = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
    }
}
