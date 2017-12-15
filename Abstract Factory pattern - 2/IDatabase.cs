using System;
using System.Data.Common;

namespace BridgeTechWhizz
{
    public interface IDatabase
    {
        DbConnection Connection { get; set; }

        void CreateConnection();

        void PrintConnection();
    }
}