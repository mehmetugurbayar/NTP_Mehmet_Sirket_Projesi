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
    public class Helper : IDisposable
    {
        SqlConnection cn = null;
        SqlCommand cmd=null;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);

            cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            Ac();
            int sonuc = cmd.ExecuteNonQuery();
            Kapa();
            return sonuc;
        }
        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
            cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            Ac();
          
            return cmd.ExecuteReader(CommandBehavior.CloseConnection); //kapatır
        }

        //public SqlDataAdapter DataAdapter(string cmdtext) //data adapter türünde bir dönüş olması lazım
       // {
            //cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
            //cmd = new SqlCommand(cmdtext, cn);
            //SqlDataAdapter dneme = new SqlDataAdapter();
            //if (cmd!=null)
            //{
            //    dneme = cmd;
            //}
            //Ac();

            

            //return dneme;
        //}




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

        public void Dispose()
        {
            if (cn != null && cmd != null)
            {
                cn.Dispose();
                cmd.Dispose();
            }
        }
    }
}
