using System;

namespace HelloWorld.Intermediate.Exercises
{
    class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an Email...");
        }
    }
}