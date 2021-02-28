using System;

namespace HelloWorld.Intermediate.Polymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine($"Sending via SMS: \"{message.MessageText}\"");
        }
    }
}