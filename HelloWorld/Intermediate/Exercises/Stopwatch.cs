﻿using System;

namespace HelloWorld.Intermediate.Exercises
{
    class Stopwatch
    {
        private DateTime TimeStarted { get; set; }
        private DateTime TimeStopped { get; set; }
        private TimeSpan TotalDuration { get; set; }
        private bool IsStarted { get; set; }

        public TimeSpan Duration
        {
            get
            {
                var currentDuration = TimeStopped - TimeStarted;
                TotalDuration += currentDuration;
                return TotalDuration;
            }
        }

        public void Start()
        {
            if (!IsStarted)
            {
                TimeStarted = DateTime.Now;
                IsStarted = true;
            }
            else
            {
                throw new InvalidOperationException("Cannot start the watch that has already been started");
            }

        }

        public void Stop()
        {
            if (IsStarted)
            {
                TimeStopped = DateTime.Now;
                IsStarted = false;
            }
            else
            {
                throw new InvalidOperationException("Cannot stop the watch that hasn't been started");
            }
        }
    }
}