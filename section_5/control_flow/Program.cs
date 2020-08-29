using System;

namespace control_flow
{
    class Program
    {
        static int ProblemOne()
        {
            var NumbersDivisibleByThree = 0;

            for (var i = 1; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    NumbersDivisibleByThree++;
                }
            }

            return NumbersDivisibleByThree;

        }

        static float ProblemTwo() {
            var TotalSum = 0f;

            while (true)
            {
                System.Console.Write("Please Enter a Number: ");
                var input = System.Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                } else {
                    try {
                        var ParsedInput = float.Parse(input);
                        TotalSum += ParsedInput;
                    } catch (Exception)
                    {
                        System.Console.WriteLine("Input was not recognized as a number. Please try again.");
                    } 
                }
            }

            return TotalSum;

        }

        static int ProblemThree() {
            System.Console.WriteLine("Please enter a number: ");
            var input = System.Console.ReadLine();
            try {
                var ParsedInput = int.Parse(input);
                var factorial = 1;
                for (var i = ParsedInput; i > 0; i--)
                {  
                    factorial = factorial * i;
                }

                return factorial;
            } catch (Exception)
            {
                System.Console.WriteLine("Sorry, that input was not valid.");
            }
            return 0;
        }

        static bool ProblemFour()
        {
            var random = new Random();
            var NumberRemainingGuesses = 4;
            var TargetNumber = random.Next(1, 10);
            while (NumberRemainingGuesses > 0)
            {
                System.Console.Write("Please guess the number: ");
                var input = System.Console.ReadLine();
                try {
                    var ParsedInput = int.Parse(input);
                    if (ParsedInput == TargetNumber)
                    {
                        System.Console.WriteLine("You got it right!!!!!");
                        return true;
                    }
                    NumberRemainingGuesses--;
                } catch (Exception)
                {
                    System.Console.WriteLine("Unable to parse your input");
                }
            }
            System.Console.WriteLine("Sorry, you did badly");
            return false;
        }

        static void ProblemFive()
        {
            System.Console.Write("Please enter a comma-delimited list of numbers: ");
            var input = System.Console.ReadLine();
            try {
                int[] ParsedInput = System.Array.ConvertAll(input.Split(","), int.Parse);
                int curMax = 0;
                foreach (int cur in ParsedInput)
                {
                    if (cur > curMax)
                    {
                        curMax = cur;
                    }
                }
                 System.Console.WriteLine(curMax);
            } catch (Exception)
            {
                System.Console.WriteLine("Unable to parse input");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //for loop
            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            // while loop
            var j = 0;
            while (j <= 20)
            {
                if (j % 2 == 0)
                {
                    System.Console.WriteLine(j);
                }
                j++;
            }

            // example of natural while usage
            while (true)
            {
                System.Console.Write("Type your name: ");
                var input = System.Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
                
            }
            // demonstration of ascii integer mapping
            // and overloading of string instantiation to accept a
            // character array
            var random = new Random();
            const int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
            System.Console.WriteLine(password);
            
            //System.Console.WriteLine((int)'a');

            //System.Console.WriteLine(ProblemOne());

            //System.Console.WriteLine(ProblemTwo());

            //System.Console.WriteLine(ProblemThree());

            //System.Console.WriteLine(ProblemFour());

            ProblemFive();


        }
    }
}
