using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.MODEL
{
   public class Musteri
    {
        string musteri_ad,musteri_soyad,tel,adres;
        int musteri_kod;

        public string Musteri_ad { get => musteri_ad; set => musteri_ad = value; }
        public string Musteri_soyad { get => musteri_soyad; set => musteri_soyad = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Adres { get => adres; set => adres = value; }
        public int Musteri_kod { get => musteri_kod; set => musteri_kod = value; }
    }
}
