using System;
namespace database_connector
{
    public class DbCommand
    {
        public DbConnection DatabaseConnection { get; set; }

        public string Instruction { get; set; }
        public DbCommand(DbConnection databaseConnection, string instruction)
        {
            if (databaseConnection == null)
                throw new ArgumentNullException("databaseConnection", "You must provide a database connection");
            if (String.IsNullOrWhiteSpace(instruction))
                throw new ArgumentNullException("instruction", "You must provide an instruction");
            this.DatabaseConnection = databaseConnection;
            this.Instruction = instruction;
        }

        public void Execute()
        {
            this.DatabaseConnection.Connect();
            System.Console.WriteLine("Running the instruction: " + this.Instruction);
            this.DatabaseConnection.Close();
        }
    }
}