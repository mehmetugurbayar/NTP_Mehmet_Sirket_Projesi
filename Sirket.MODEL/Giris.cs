using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.MODEL
{
    public class Giris
    {
        int yetki;
        string kullanici_ad, kullanici_sifre;

        public string Kullanici_sifre { get => kullanici_sifre; set => kullanici_sifre = value; }
        public string Kullanici_ad { get => kullanici_ad; set => kullanici_ad = value; }
        public int Yetki { get => yetki; set => yetki = value; }
    }
}
