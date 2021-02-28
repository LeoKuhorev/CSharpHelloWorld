using System;
using System.IO;

namespace HelloWorld.Intermediate.Interfaces
{
    public class Interfaces
    {
        public static void Demo()
        {
            // Using ConsoleLogger
            var dbMigrator = new DbMigrator(new ConsoleLogger()); // Passing an instance of the actual logger from the main method
            dbMigrator.Migrate();

            // Using FileLogger
            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent;
            {
                if (directoryInfo != null)
                {
                    var solutionPath = Path.Combine(directoryInfo
                        .FullName, @"\Intermediate\Interfaces");

                    var dbMigratorOne = new DbMigrator(new FileLogger($@"{solutionPath}\log.txt"));
                    dbMigratorOne.Migrate();
                }
            }
        }
    }
}