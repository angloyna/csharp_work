using System;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myStopWatch = new Stopwatch();
            myStopWatch.Start();
            System.Console.WriteLine("Interval during: " + myStopWatch.Interval);
            myStopWatch.Stop();
            System.Console.WriteLine("Interval at the end: " + myStopWatch.Interval);

            myStopWatch.Start();
            System.Console.WriteLine("Interval during: " + myStopWatch.Interval);
            myStopWatch.Stop();
            System.Console.WriteLine("Interval at the end: " + myStopWatch.Interval);

            myStopWatch.Start();
            System.Console.WriteLine("Interval during: " +  myStopWatch.Interval);
            myStopWatch.Clear();
            myStopWatch.Start();
            System.Console.WriteLine("Interval during: " +  myStopWatch.Interval);
            myStopWatch.Stop();
            System.Console.WriteLine("Interval at the end: " + myStopWatch.Interval);
        }
    }
}
