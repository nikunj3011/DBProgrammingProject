using System;
using System.Data;
using System.Data.SqlClient;

/*
    NAME: Nikunj Rathod

*/
using CM = System.Configuration.ConfigurationManager;//ConfigurationManager alias import

namespace ComputerFields
{
    internal class DataAccess
    {
        private static string connectionString = CM.ConnectionStrings["ComputerFieldsConnStr"].ConnectionString;

        /// <summary>
        /// Queries a SQL Server database with a provided SELECT statement.
        /// </summary>
        /// <param name="sql">The SELECT SQL Statement to execute and query data</param>
        /// <returns>DataTable containing results from the provided SQL statement</returns>
        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }


        /// <summary>
        /// Queries a SQL Server database for a scalar (single) value from the provided SELECT statement.
        /// </summary>
        /// <param name="sql">The SELECT SQL Statement to execute and query data for a scalar (single) value</param>
        /// <returns>The scalar value of the result of the SQL Statement execution</returns>
        public static object GetValue(string sql)
        {
            object returnValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                returnValue = cmd.ExecuteScalar();
                conn.Close();
            }

            return returnValue;
        }


        public DataTable GetDataTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }

        /// <summary>
        /// Queries a SQL Server database with a provided SELECT statement.
        /// </summary>
        /// <param name="sql">The SELECT SQL Statement to execute and query data</param>
        /// <returns>DataTable containing results from the provided SQL statement</returns>


        internal static DataSet GetDataSet(SqlCommand cmd)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }

            return ds;
        }


        public static DataSet GetDataa(string[] sqlStatements)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = String.Join(";", sqlStatements);

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                for (int i = 0; i < sqlStatements.Length; i++)
                {
                    da.TableMappings.Add(i.ToString(), $"Data{i}");
                }

                da.Fill(ds);
            }

            return ds;
        }

        internal static object GetValue(SqlCommand cmd)
        {
            object returnValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;

                conn.Open();
                returnValue = cmd.ExecuteScalar();
                conn.Close();
            }

            return returnValue;
        }

        internal static int ExecuteNonQuery(SqlCommand cmd)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;

                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return rowsAffected;
        }
    }
}
