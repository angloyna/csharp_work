using System;

namespace database_connector
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString) ){
                throw new ArgumentNullException("connectionString", "You must provide a connection string.");
            }
            this.ConnectionString = connectionString;
        }

        public TimeSpan Timeout { get; set; }
        public abstract void Connect();

        public abstract void Close();

    }
}