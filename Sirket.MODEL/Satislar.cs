﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.MODEL
{
    public class Satislar //MUSTERİ VE PERSONEL İLE ÇALIŞAN TABLONUN MODELİ
    {
        int satis_kod, musteri_id, personel_id,urun_id;
        string tarih;
        public int Personel_id { get => personel_id; set => personel_id = value; }

        public int Musteri_id { get => musteri_id; set => musteri_id = value; }
        public int Urun_id { get => urun_id; set => urun_id = value; }
        public string Tarih { get => tarih; set => tarih = value; }
        public int Satis_kod { get => satis_kod; set => satis_kod = value; }

        public int  Satis_adet{ get; set; }




    }
}
