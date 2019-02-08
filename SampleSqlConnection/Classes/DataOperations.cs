using System;
using System.Data.SqlClient;
using KarenBase.ConnectionClasses;

namespace SampleSqlConnection.Classes
{
    public class DataOperations : SqlServerConnection
    {
        public void TestSqlConnection()
        {
            /*
             * Server name or .\SQLEXPRESS
             */
            DatabaseServer = "KARENS-PC";
            /*
             * Database name residing on server
             */
            DefaultCatalog = "NorthWindAzure3";

            Console.WriteLine($"Connection string: {ConnectionString}");
            Console.WriteLine();
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                try
                {
                    cn.Open();
                }
                catch (Exception ex)
                {
                    mHasException = true;
                    mLastException = ex;
                }
            }
        }
    }
}
