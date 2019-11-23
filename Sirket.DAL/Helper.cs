using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.DAL
{
    public class Helper
    {
        SqlConnection cn = null;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);//hata veriyor

            SqlCommand cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            Ac();
            int sonuc = cmd.ExecuteNonQuery();
            Kapa();
            return sonuc;
        }

        public void Ac()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open) cn.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Kapa()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Closed) cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
