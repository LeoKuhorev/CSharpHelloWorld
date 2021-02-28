using System;
using System.ComponentModel;

namespace HelloWorld.Intermediate.Exercises
{
    abstract class DbConnection
    {
        public TimeSpan Timeout { get; set; }
        public string ConnectionString { get; set; }

        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidEnumArgumentException(nameof(connectionString));

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}