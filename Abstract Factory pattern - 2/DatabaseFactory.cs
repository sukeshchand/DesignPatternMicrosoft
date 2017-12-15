using System;
using System.Data.Common;

namespace BridgeTechWhizz
{
    public class DatabaseFactory
    {
        public static IDatabase GetDatabaseObject(string databaseType)
        {
            if (databaseType == "1")
            {
                return new DatabaseOleDb();
            }
            else if (databaseType == "2")
            {
                return new DatabaseSqlServer();
            }
            else
            {
                return null;
            }
        }
    }
}