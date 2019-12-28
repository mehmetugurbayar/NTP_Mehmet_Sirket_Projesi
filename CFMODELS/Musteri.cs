using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFMODELS
{
    public class Musteri
    {
        public int MusteriId { get; set; } //primary key
        public string Musteri_kod{ get; set; }
        public string Musteri_ad { get; set; }
        public string Musteri_soyad { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
    }
}
