using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Basics
{
    class DatesAndTime
    {
        public static void Demo()
        {
            var dateTime = new DateTime(2021, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var yesterday = today.AddDays(-1);

            Console.WriteLine(now.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());


            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = TimeSpan.FromHours(1);

            var duration = tomorrow - yesterday;
            Console.WriteLine("Duration: " + duration);

        }
    }
}
