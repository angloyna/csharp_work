using System;
using System.Collections.Generic;

namespace arrays
{
    class Program
    {
        static void ProblemOne()
        {
            var FriendsEntered = new List<string>();
            while (true)
            {
                System.Console.Write("Please Enter a friend: ");
                var input = System.Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                FriendsEntered.Add(input);
            }
            if (FriendsEntered.Count == 1)
            {
                System.Console.WriteLine(String.Format("{0} likes your post.", FriendsEntered[0]));
            }
            else if (FriendsEntered.Count == 2)
            {
                System.Console.WriteLine(String.Format("{0} and {1} like your post.", FriendsEntered[0], FriendsEntered[1]));
            } else if (FriendsEntered.Count > 2)
            {
                var AdditionalFriends = FriendsEntered.Count - 2;
                System.Console.WriteLine(String.Format("{0}, {1}, and {2} others like your post.", FriendsEntered[0], FriendsEntered[1], AdditionalFriends));
            }
        }
        static void ProblemTwo()
        {
            System.Console.WriteLine("Enter your name: ");
            var input = System.Console.ReadLine();
            char[] name_array = input.ToCharArray();
            Array.Reverse(name_array);

            System.Console.WriteLine(String.Join("", name_array));
        }

        static void ProblemThree()
        {
            var numbersEntered = new float[5];
            var NumberSuccessfulAttempts = 0;

            while (NumberSuccessfulAttempts < 5)
            {
                System.Console.WriteLine("Enter a number: ");
                var input = System.Console.ReadLine();
                try {
                    var ParsedInput = float.Parse(input);
                    if (Array.IndexOf(numbersEntered, ParsedInput) >= 0)
                    {
                        System.Console.WriteLine("Sorry that number has already been entered. Try again.");
                        continue;
                    }
                    numbersEntered[NumberSuccessfulAttempts] = ParsedInput;
                    NumberSuccessfulAttempts++;
                } catch (Exception)
                {
                    System.Console.WriteLine("Input was not able to be parsed.");
                }
            }
            Array.Sort(numbersEntered);
            foreach (var number in numbersEntered)
            {
                System.Console.WriteLine(number);
            }
        }
        static void ProblemFour()
        {
            var NumbersEntered = new List<float>();
            while (true)
            {
                System.Console.WriteLine("Enter a number: ");
                var input = System.Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                try {
                    var ParsedInput = float.Parse(input);
                    if  (NumbersEntered.IndexOf(ParsedInput) < 0)
                    {
                        NumbersEntered.Add(ParsedInput);
                    }
                } catch (Exception)
                {
                    System.Console.WriteLine("Unable to parse your response");
                }
            }
            foreach (var number in NumbersEntered)
            {
                System.Console.WriteLine(number);
            }
        }

        static void ProblemFive()
        {   
            float[] FinalAnswer;
            while (true)
            {
                try
                {
                    float[] numbers;
                    System.Console.Write("Please enter a list of numbers");
                    var input = System.Console.ReadLine();
                    numbers = Array.ConvertAll(input.Split(","), float.Parse);
                    if (numbers.Length < 5)
                    {
                        System.Console.WriteLine("Invalid List. Try again.");
                        continue;
                    } else {
                        FinalAnswer = numbers;
                        break;
                    }
                } catch (Exception) {
                    System.Console.WriteLine("Invalid List. Try again");
                }
            }
            Array.Sort(FinalAnswer);
            for (int i = 0; i<3; i++)
            {
                System.Console.WriteLine(FinalAnswer[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // C# has both arrays (fixed-sized) and lists(dynamic)
            var numbers = new List<int>() { 1, 2, 3, 4 };
            // arrays do not hae an add method
            numbers.Add(5);
            numbers.AddRange(new int[3] { 6, 7, 8 });

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
                
                System.Console.WriteLine(numbers.IndexOf(number));
            }

            ProblemOne();
            ProblemTwo();
            ProblemThree();
            ProblemFour();
            ProblemFive();
        }
    }
}
