using System;
using System.Threading;

namespace Stopwatch
{
    public class StopWatch
    {
        private DateTime StartTime;
        private DateTime StopTime;
        private bool running;

        public void Start()
        {
            if (running)
                throw new InvalidOperationException("StopWatch is already Running");

            StartTime = DateTime.Now;
            running = true;
        }

        public void Stop()
        {
            if (running)
            {
                StopTime = DateTime.Now;
                running = false;
            }
            else
                throw new InvalidOperationException("StopWatch is already Stopped");
        }


        public TimeSpan GetInterval()
        {
            return StopTime - StartTime;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

           
            while (true)
            {
                stopwatch.Start();
                Thread.Sleep(2000);
                stopwatch.Stop();

                Console.WriteLine("The Time Interval is" + stopwatch.GetInterval());

                Console.WriteLine("Do yo want to continue If Yes Press 'Y'  otherwise Press any key For Exit");
                var result = Console.ReadLine();
                if ((result == "y") || (result == "Y"))
                { continue; }
                else
                    break;
            }
        }

    }
}

