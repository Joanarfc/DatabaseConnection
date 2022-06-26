using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Test the insertion of a null connection:
            //SQLConnection sqlDatabase = new SQLConnection(null);
            //OracleConnection oracleDatabase = new OracleConnection(" ");

            SQLConnection sqlConnection = new SQLConnection("123");
            //sqlConnection.OpenConnection();
            //sqlConnection.CloseConnection();

            OracleConnection oracleConnection = new OracleConnection("678");
            //oracleConnection.OpenConnection();
            //oracleConnection.CloseConnection();

            DbCommand instruction = new DbCommand(sqlConnection, "Insert");
            instruction.Execute();
        }
    }
}
