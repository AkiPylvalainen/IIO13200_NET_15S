using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tehtava6TestBench
{
    class DBPlacebo
    {
        public static DataTable ExecuteSelectCommand(String connectionString, String table)
        {
            DataTable dt = null;

            String query = "SELECT * FROM " + table;

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

        public static DataTable ExecuteCommand(String connectionString, String table, String query)
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
    }
}
