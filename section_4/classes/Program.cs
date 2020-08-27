using System;
using classes.Math;

namespace classes
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();
            Calculator calc = new Calculator();
            var result = calc.Add(1, 2);
            System.Console.WriteLine(result);

            var numbers = new int[3];
            numbers[0] = 1;
            System.Console.WriteLine(numbers[0]);
            System.Console.WriteLine(numbers[1]);
            System.Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            var names = new string[3] { "Jack", "John", "Mary" };

            string list = string.Join(", ", numbers);
            System.Console.WriteLine(list);

        }
    }
}
