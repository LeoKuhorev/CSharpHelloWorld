using System;
using System.Collections;
using System.Threading;

namespace HelloWorld.Intermediate.Exercises
{
    class Demo
    {
        public static void StopwatchDemo()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(2000);
            stopwatch.Stop();
            Console.WriteLine("The durations is: " + stopwatch.Duration);

            try
            {
                Console.WriteLine("Trying to stop the stopwatch that hasn't been started");
                stopwatch.Stop();

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("An error has occurred. " + e);
            }
            stopwatch.Start();
            Thread.Sleep(2000);
            stopwatch.Stop();
            Console.WriteLine("The durations is: " + stopwatch.Duration);
        }

        public static void PostDemo()
        {
            var post = new Post("New Post", "This is the description of a new post");
            Console.WriteLine("Post created at: " + post.CreatedAt);
            Console.WriteLine("Initial rating is: " + post.Rating);
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine("New rating is: " + post.Rating);
        }

        public static void StackDemo()
        {
            try
            {
                var stack = new Stack();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred running the method: " + e);
            }
        }

        public static void DbConnectionDemo()
        {
            var sqlConnection = new SqlConnection("This is an SQL connection string");
            var oracleConnection = new OracleConnection("This is an Oracle connection string");

            var sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM table WHERE id=1");
            var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM another_table WHERE id=2");

            sqlCommand.Execute();
            Console.WriteLine();
            oracleCommand.Execute();
        }

        public static void WorkFlowEngineDemo()
        {
            var workFlow = new WorkFlow();
            workFlow.AddActivity(new SendEmail());
            workFlow.AddActivity(new CheckEmail());

            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Run(workFlow);

        }

        
    }
}
