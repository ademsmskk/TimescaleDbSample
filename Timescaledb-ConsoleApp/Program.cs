using System;

namespace Timescaledb_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimescaleHelper ts = new TimescaleHelper();


            ts.CheckDatabaseConnection();
            ts.insertData();
            ts.runQuery();
            ts.CreateRelationalData();
            ts.CreateHypertable();
            ts.insertData2();
            ts.RunQueryExample();




           
        }
    }
}
