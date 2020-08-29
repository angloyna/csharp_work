using System;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dateTime = new DateTime(2015, 1, 1);

            var start = DateTime.Now;
            var end = start.AddMinutes(2);
            var duration = end - start;
            System.Console.WriteLine(duration);

        }
    }
}
