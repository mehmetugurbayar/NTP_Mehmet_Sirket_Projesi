using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.MODEL
{
    public class Satis //URUNLERLE CALIŞAN TABLONUN MODELİ
    {
        string tarih, satis_kod;
        int  urun_id, fiyat, musteri_id, personel_id, satilan_adet;

        
        


        public string Satis_kod { get => satis_kod; set => satis_kod = value; }


        public int Personel_id { get => personel_id; set => personel_id = value; }

        public int Musteri_id { get => musteri_id; set => musteri_id = value; }
        public int Urun_id { get => urun_id; set => urun_id = value; }
        public string Tarih { get => tarih; set => tarih = value; }
        public int Satilan_adet { get => satilan_adet; set => satilan_adet = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }

    }
}
