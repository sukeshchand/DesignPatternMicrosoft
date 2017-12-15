using System;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;

namespace BridgeTechWhizz
{
    public class DatabaseOleDb : IDatabase
    {
        public DatabaseOleDb()
        {
            CreateConnection(); // calling factory method - Second factory method give the connection and command
        }
        public DbConnection Connection { get; set; }

        public void CreateConnection() // factory method to decide connection and command type
        {
            Connection = new OleDbConnection();
        }

        public void PrintConnection()
        {
            Console.WriteLine("ConnectionString: OleDbConnection, Command Type: OleDbCommand");
        }
    }
}