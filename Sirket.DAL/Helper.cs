﻿using System;
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

            SqlDataReader dr= cmd.ExecuteReader(CommandBehavior.CloseConnection); //kapatır
            return dr;
        }
      
        public DataTable TabloGetir(string cmdtext)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
            DataTable dt = new DataTable();
            
            
            da.Fill(dt);
            return dt;
        }

    
        
        public void Ac()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
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
