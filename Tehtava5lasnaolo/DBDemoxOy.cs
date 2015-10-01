using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tehtava5lasnaolo
{
    class DBDemoxOy
    {
        public static DataTable GetDataTable(String connectionString, String table)
        {
            DataTable dt = null;

            String query = "SELECT asioid, lastname, firstname, date FROM " + table;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) { 
                        DataSet ds = new DataSet();
                        da.Fill(ds, table);
                        dt = ds.Tables[table];
                    }

                    cmd.Dispose();
                    cmd = null;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public static DataTable GetDataTable(String connectionString, String table, String query)
        {
            DataTable dt = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, table);
                        dt = ds.Tables[table];
                    }

                    cmd.Dispose();
                    cmd = null;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public static DataView GetDataView(String connectionString, String table, String param)
        {
            DataView dv = null;
            //DataTable dt = null;

            String query = "SELECT asioid, lastname, firstname, date FROM " + table + " WHERE asioid = '" + param + "'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, table);
                        //dt = ds.Tables[table];

                        dv = new DataView(ds.Tables[table]);
                    }

                    cmd.Dispose();
                    cmd = null;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dv;
        } 
    }
}
