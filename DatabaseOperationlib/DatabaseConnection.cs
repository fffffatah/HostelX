using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseOperationlib
{
    public class DatabaseConnection:IDisposable
    {
        SqlConnection con;
        SqlCommand command;

        public DatabaseConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureDb"].ConnectionString);
            con.Open();
            command = new SqlCommand();
            command.Connection = con;
        }

        public void CreateQuery(string query)
        {
            command.CommandText = query;
            command.CommandTimeout = 15;
            command.CommandType = CommandType.Text;
        }

        public void Dispose()
        {
            con.Close();
        }

        public SqlDataReader DoQuery()
        {
            return command.ExecuteReader();
        }

        public int DoNoQuery()
        {
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return -1;
        }
    }
}
