using System.Collections.Generic;

namespace HelloWorld.Intermediate.Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            // Video encoding logic goes here...

            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message("Your video has been encoded"));
            }
        }

        public void RegisterNotificationChannel(INotificationChannel notificationChannel)
        {
            _notificationChannels.Add(notificationChannel);
        }
    }
}