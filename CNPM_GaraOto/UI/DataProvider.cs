using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
        }

        private string connectionsql = "Data Source=DESKTOP-K0VVO9B;Initial Catalog=QuanLyGaraOTo;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable df = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionsql))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (string item in list)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(df);
                connection.Close();
            }
            return df;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int rows = 0;
            using (SqlConnection connection = new SqlConnection(connectionsql))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (string item in list)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return rows;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object sl = 0;
            using (SqlConnection connection = new SqlConnection(connectionsql))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (string item in list)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                sl = cmd.ExecuteScalar();
                connection.Close();
            }
            return sl;
        }

        
    }
}