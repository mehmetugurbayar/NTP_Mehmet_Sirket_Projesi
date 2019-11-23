using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.MODEL
{
    public class Urunler
    {
        string urun_kodu, urun_ad;
        int stok_mik, fiyat;


        public string Urun_kodu { get => urun_kodu; set => urun_kodu = value.Trim(); }
        public string Urun_ad { get => urun_ad; set => urun_ad = value.Trim(); }
        public int Stok_mik { get => stok_mik; set => stok_mik = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        
    }
}
