using CFDAL;
using CFMODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrktCFBLL
{
    public class MusteriBL:IDisposable
    {
        SirketContext sctx = new SirketContext();

        public void Dispose()
        {
            ((IDisposable)sctx).Dispose();
        }

        public void MusteriEkle(Musteri m)
        {
            sctx.Musteriler.Add(m);
        }

        public bool MusteriSil(Musteri mstr) 
        {   
            //SET: DBset üzerinden işlem yapmak için tabloyu bu şekilde belirliyoruz
            //first: arama yaptıktan sonra dönen ilk değeri alır musteriye atar --firstordefault ta kullanılabilir
            Musteri musteri= sctx.Set<Musteri>().Where(m => m.Musteri_kod== mstr.Musteri_kod).First();
            sctx.Set<Musteri>().Remove(musteri);
            
            return sctx.SaveChanges() > 0;
        }
        public void MusteriGuncelle(Musteri mstr)
        {
            Musteri musteri = sctx.Set<Musteri>().Where(m => m.Musteri_kod == mstr.Musteri_kod).First();
            sctx.Set<Musteri>().(musteri);

        }


        public int SaveChanges()
        {
            return sctx.SaveChanges();
        }
    }
}
