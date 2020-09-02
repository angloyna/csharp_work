namespace database_connector
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            
        }

        public override void Connect()
        {

            System.Console.WriteLine("You have opened a SqlConnection");

        }

        public override void Close()
        {
            System.Console.WriteLine("You have closed a Sql Connection");
        }

    }
}