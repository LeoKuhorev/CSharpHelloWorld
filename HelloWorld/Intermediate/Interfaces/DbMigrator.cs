using System;

namespace HelloWorld.Intermediate.Interfaces
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");
            
            // Implementation
            _logger.LogError("An error occurred - your method misses the actual implementation!");

            _logger.LogInfo($"Migration ended at {DateTime.Now}");
        }
    }
}