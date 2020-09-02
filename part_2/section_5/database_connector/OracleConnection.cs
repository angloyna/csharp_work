namespace database_connector
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            
        }

        public override void Connect()
        {
            System.Console.WriteLine("You have opened an Oracle Database Connection");
        }

        public override void Close()
        {
            System.Console.WriteLine("You have closed an Oracle Database Connection");
        }
    }
}