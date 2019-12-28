using CFMODELS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDAL
{
    public class SirketContext : DbContext
    {
        public SirketContext():base("cstr"){}


        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri>().ToTable("CF_Musteri_Tablosu"); //musteriyi içinde barındırcak tabloya isim verdik
            //                                         . oklar goes to demek --lambda expression
            modelBuilder.Entity<Musteri>().Property(m => m.Musteri_kod).IsRequired().HasMaxLength(20).HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(m => m.Musteri_ad).IsRequired().HasMaxLength(20).HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(m => m.Musteri_soyad).IsRequired().HasMaxLength(15).HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(m => m.Tel).IsRequired().HasMaxLength(12).HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(m => m.Adres).IsRequired().HasMaxLength(50).HasColumnType("varchar");
        }


        // enable-migraitons server a atmak için configuration classı yazar
        // update-database değişiklikleri oluşturulab db ye atar
    }
}
