using System;


namespace stopwatch
{
    class Stopwatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public TimeSpan Interval {
            get
            {
                if (this.StartTime == DateTime.MinValue)
                    throw new InvalidOperationException("Unable to calculte time elapsed. Is your stopwatch running?");
                if (this.EndTime == DateTime.MinValue)
                    return DateTime.Now - StartTime;
                return EndTime - StartTime;  
            }
        }

        public void Start()
        {
            if (this.StartTime != DateTime.MinValue)
                throw new InvalidOperationException("Stopwatch timing in progress. You cannot start the stopwatch at this time.");
            this.StartTime = DateTime.Now;
            this.EndTime = DateTime.MinValue;
        }

        public void Stop()
        {
            if (this.StartTime != DateTime.MinValue)
                this.EndTime = DateTime.Now;
        }

        public void Clear()
        {
            this.StartTime = this.EndTime = DateTime.MinValue;
        }

    }
}