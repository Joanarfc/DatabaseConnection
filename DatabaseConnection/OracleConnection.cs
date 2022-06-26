using System;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }
        public override void OpenConnection()
        {
            Console.WriteLine("Opening the Oracle database connection");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closing the Oracle database connection");
        }


    }
}