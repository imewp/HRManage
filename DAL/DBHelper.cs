using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    class DBHelper
    {
        static string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["HRManageConnStr"].ToString();

        static void PrepareCommand(SqlConnection conn, SqlCommand comm, string comText, CommandType comType, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            comm.Connection = conn;
            comm.CommandText = comText;
            comm.CommandType = comType;
            if (cmdParms != null)
            {
                foreach (SqlParameter p in cmdParms)
                {
                    comm.Parameters.Add(p);
                }
            }
        }

        public static DataSet SelectToDS(string sql, CommandType comType, params SqlParameter[] cmdParms)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    PrepareCommand(conn, comm, sql, comType, cmdParms);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comm))
                    {
                        DataSet ds = new DataSet();
                        try
                        {
                            adapter.Fill(ds);
                            comm.Parameters.Clear();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        return ds;
                    }
                }
            }
        }

        public static int ExecuteSql(string sql, CommandType comType, params SqlParameter[] cmdParms)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    PrepareCommand(conn, comm, sql, comType, cmdParms);
                    try
                    {
                        int rows = comm.ExecuteNonQuery();
                        comm.Parameters.Clear();
                        return rows;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
    }
}
