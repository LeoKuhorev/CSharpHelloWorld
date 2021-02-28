using System;

namespace HelloWorld.Intermediate.Exercises
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL DB connection...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL DB connection...");
        }
    }
}