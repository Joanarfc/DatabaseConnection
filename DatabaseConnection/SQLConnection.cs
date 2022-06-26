using System;

namespace DatabaseConnection
{
    internal class SQLConnection : DbConnection
    {
        public SQLConnection(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening the SQL database connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing the SQL database connection");
        }
    }
}