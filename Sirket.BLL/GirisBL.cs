using Sirket.DAL;
using Sirket.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sirket.BLL
{
    public class GirisBL
    {
        Helper hlp = new Helper();

         
        public Giris Giris_Kontrol(int yetki,string kul_adi,string kul_sifre)
        {
            try
            {
                //if içine giriyor değerleri atıyor ama giris dönerken değerler null dönüyor 
                SqlParameter[] p = { new SqlParameter("@yetki", yetki), new SqlParameter("@kul_ad",kul_adi), new SqlParameter("@kul_sifre", kul_sifre) };
                SqlDataReader dr = hlp.ExecuteReader("Select yetki,kul_ad,kul_sifre from Giris_Tablosu where yetki=@yetki,kul_adi=@kul_ad,kul_sifre=@kul_sifre", p);

                Giris giris = null;

                if (dr.Read())
                {
                    giris = new Giris();
                    giris.Yetki = Convert.ToInt32(dr["yetki"]);
                    giris.Kullanici_ad = dr["kul_adi"].ToString();
                    giris.Kullanici_sifre = dr["kul_sifre"].ToString();
                }
                dr.Close();

                return giris;
            }
            catch (SqlException r)
            {
                Console.WriteLine("HATAAAAAAAA:"+r.Number);
                throw;
            }

        }

    }
}
