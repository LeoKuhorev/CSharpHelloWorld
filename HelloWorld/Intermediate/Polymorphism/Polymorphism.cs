namespace HelloWorld.Intermediate.Polymorphism
{
    public class Polymorphism
    {
        public static void Demo()
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}