﻿using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
