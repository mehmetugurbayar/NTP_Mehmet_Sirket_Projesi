using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.MODEL
{
  public  class Personel
    {
        string perso_ad, perso_soyad, perso_cinsiyet,tel,mail,dogum_tarihi,dogum_yeri,unvan,pozisyon,baslama_tarihi;
        int maas, perso_kod; //int tutmamın sebebi belki hesaplama yapılabilir.

        public int Perso_kod { get => perso_kod; set => perso_kod = value; }
        public string Perso_ad { get => perso_ad; set => perso_ad = value; }
        public string Perso_soyad { get => perso_soyad; set => perso_soyad = value; }
        public string Perso_cinsiyet { get => perso_cinsiyet; set => perso_cinsiyet = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Dogum_tarihi { get => dogum_tarihi; set => dogum_tarihi = value; }
        public string Dogum_yeri { get => dogum_yeri; set => dogum_yeri = value; }
        public string Unvan { get => unvan; set => unvan = value; }
        public string Pozisyon { get => pozisyon; set => pozisyon = value; }
        public string Baslama_tarihi { get => baslama_tarihi; set => baslama_tarihi = value; }
        public int Maas { get => maas; set => maas = value; }
        
    }
}
