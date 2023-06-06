using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StopWatch
    {
        DateTime startTime;
        DateTime endTime;

        public DateTime StartTime
        {
            get { return startTime; }
        }

        public DateTime EndTime
        {
            get { return endTime; }
        }

        public StopWatch()
        {
            startTime = DateTime.Now;
            endTime = startTime;
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public double GetElapsedTime()
        {
            TimeSpan elapsed = endTime - startTime;
            return elapsed.TotalMilliseconds;
        }
    }
}
