using System;

namespace DatabaseConnection
{
    public class DbCommand
    {
        DbConnection Connection;
        public string DatabaseInstruction;
        public DbCommand(DbConnection connection, string databaseInstruction)
        {
            if (String.IsNullOrWhiteSpace(databaseInstruction))
                throw new InvalidOperationException("Instruction can't be null, empty or an whitespace.");

            Connection = connection;
        }

        public void Execute()
        {
            Connection.OpenConnection();
            Console.WriteLine(DatabaseInstruction);
            Connection.CloseConnection();
        }
    }
}