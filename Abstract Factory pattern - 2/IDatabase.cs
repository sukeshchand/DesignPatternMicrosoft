using System;
using System.Data.Common;

namespace BridgeTechWhizz
{
    public interface IDatabase
    {
        DbConnection Connection { get; set; }
        DbCommand Command { get; set; }

        void CreateConnectionAndCommand();

        void PrintConnection();
    }
}