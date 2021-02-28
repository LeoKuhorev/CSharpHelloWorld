using System;

namespace HelloWorld.Intermediate.Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine($"Sending via email: \"{message.MessageText}\"");
        }
    }
}