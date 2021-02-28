using System;

namespace HelloWorld.Intermediate.Exercises
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening Oracle DB connection...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing Oracle DB connection...");
        }
    }
}