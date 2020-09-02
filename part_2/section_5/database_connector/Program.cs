using System;

namespace database_connector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var oracle = new OracleConnection("hei:okda:fake:connectionstring");
            oracle.Connect();
            oracle.Close();
            var sqlconn = new SqlConnection("dljf:sfs");
            sqlconn.Connect();
            sqlconn.Close();

            var sqlconnTwo = new SqlConnection("dljf:sfs");
            var oracleTwo = new OracleConnection("hei:okda:fake:connectionstring");
            var command = new DbCommand(oracleTwo, "Select 1 from table;");
            command.Execute();
        }
    }
}
