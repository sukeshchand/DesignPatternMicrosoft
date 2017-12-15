using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace BridgeTechWhizz
{
    public class DatabaseSqlServer : IDatabase
    {
        public DatabaseSqlServer()
        {
            CreateConnectionAndCommand(); // calling factory method - Second factory method give the connection and command
        }
        public DbConnection Connection { get; set; }


        public void CreateConnectionAndCommand() // factory method to decide connection and command type
        {
            Connection = new SqlConnection();
        }

        public void PrintConnection()
        {
            Console.WriteLine("ConnectionString: SqlConnection, Command Type: SqlCommand");
        }

    }
}