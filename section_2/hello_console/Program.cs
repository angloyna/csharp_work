using System;

namespace hello_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation
            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // explicit type casting
            // chance of data loss, of course.
            int i = 1;
            byte b = (byte) i;
            System.Console.WriteLine(b);

            string number = '1234';
            int i = Convert.ToInt32(number);
        }
    }
}
