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

        public bool Giris_Control(string kul_ad, string kul_sifre)
        {
            try
            {

                SqlParameter[] p = { new SqlParameter("@kul_ad", kul_ad), new SqlParameter("@kul_sifre", kul_sifre) };
                SqlDataReader dr = hlp.ExecuteReader("Select kul_ad,kul_sifre from Giris_Tablosu where kul_ad=@kul_ad and kul_sifre=@kul_sifre", p);
                if (dr.Read())
                {
                    dr.Close();
                    return true;
                }
                return false;

            }
            catch (SqlException r)
            {
                Console.WriteLine("Beklendmedik Bir Hata Oluştu:" + r.Number);
                throw;
            }
        }

    }
}
