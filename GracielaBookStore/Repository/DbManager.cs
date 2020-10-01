using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GracielaBookStore.Repository
{
    public class DbManager
    {
        static SqlConnection connection = null;

        private DbManager() { }

        public static SqlConnection GetInstance()
        {
            if (connection == null)
            {
                string dbPath = HttpRuntime.AppDomainAppPath + @"App_Data\GracielaBookStore.mdf";

                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPath + ";Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }

            return connection;
        }

        public static DataTable Get(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = GetInstance())
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                connection.Close();
            }

            return dt;
        }

        public static void Execute(string query)
        {
            using (SqlConnection connection = GetInstance())
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}