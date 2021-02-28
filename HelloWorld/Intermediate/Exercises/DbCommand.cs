using System;

namespace HelloWorld.Intermediate.Exercises
{
    class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _dbCommand;

        public DbCommand(DbConnection dbConnection, string dbCommand)
        {
            if (string.IsNullOrWhiteSpace(dbCommand))
                throw new ArgumentNullException(nameof(dbCommand));

            _dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
            _dbCommand = dbCommand;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine($"Executing the command: {_dbCommand}");
            _dbConnection.CloseConnection();
        }
    }
}