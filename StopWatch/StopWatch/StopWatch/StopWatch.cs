using System;
using System.Diagnostics;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _time;
        private bool _started;

        public void Start()
        {
            if (_started)
                throw new InvalidOperationException();

            _started = true;
            _time = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            if (!_started)
                throw new InvalidOperationException();

            _started = false;
            return DateTime.Now - _time;

            

        }
        
    }
}