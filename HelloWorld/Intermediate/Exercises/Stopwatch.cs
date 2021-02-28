using System;

namespace HelloWorld.Intermediate.Exercises
{
    class Stopwatch
    {
        private DateTime _timeStarted;
        private DateTime _timeStopped;
        private TimeSpan _totalDuration;
        private bool _isStarted;

        public TimeSpan Duration
        {
            get
            {
                var currentDuration = _timeStopped - _timeStarted;
                _totalDuration += currentDuration;
                return _totalDuration;
            }
        }

        public void Start()
        {
            if (_isStarted)
                throw new InvalidOperationException("Cannot start the watch that has already been started");

            _timeStarted = DateTime.Now;
            _isStarted = true;
        }

        public void Stop()
        {
            if (!_isStarted)
                throw new InvalidOperationException("Cannot stop the watch that hasn't been started");

            _timeStopped = DateTime.Now;
            _isStarted = false;
            
        }
    }
}
