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

         
        public Giris Giris_Kontrol(Giris girmek)
        {
            try
            {
                //if içine giriyor değerleri atıyor ama giris dönerken değerler null dönüyor 
                SqlParameter[] p = { new SqlParameter("@yetki", girmek.Yetki), new SqlParameter("@kul_ad", girmek.Kullanici_ad), new SqlParameter("@kul_sifre", girmek.Kullanici_sifre) };
                SqlDataReader dr = hlp.ExecuteReader("Select yetki,kul_ad,kul_sifre from Giris_Tablosu where yetki=@yetki,kul_ad=@kul_ad,kul_sifre=@kul_sifre", p);

                Giris giris = null;
                if (dr.Read())
                {
                    giris = new Giris();
                    giris.Yetki = Convert.ToInt32(dr["yetki"]);
                    giris.Kullanici_ad = dr["kul_ad"].ToString();
                    giris.Kullanici_sifre = dr["kul_sifre"].ToString();
                }
                dr.Close();

                return giris;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
