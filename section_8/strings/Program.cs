using System;
using System.Linq;
using System.Globalization;

namespace strings
{
    class Program
    {   
        static String ProblemOne()
        {
            System.Console.Write("Enter a hypen-separated list of numbers: ");
            var input = System.Console.ReadLine();
            try {
                var ParsedInput = Array.ConvertAll(input.Split('-'), int.Parse);
                if (ParsedInput.Length <= 1)
                {
                    return "Consecutive";
                }
                var isIncreasing = ParsedInput[0] < ParsedInput[1];
                var isConsecutive = true;
                var curIndex = 1;
                while (isConsecutive && ((curIndex + 1) < ParsedInput.Length))
                {

                    var isLessThanNext = ParsedInput[curIndex] < ParsedInput[curIndex + 1];
                    var isGreaterThanNext = ParsedInput[curIndex] > ParsedInput[curIndex + 1];
                    var BreaksConsecutiveStreak = isIncreasing ? isGreaterThanNext : isLessThanNext;

                    if (BreaksConsecutiveStreak)
                    {
                        isConsecutive = false;
                    }

                    curIndex++;
                }
                return isConsecutive ? "Consecutive" : "Not Consecutive";
            } catch (Exception)
            {
                System.Console.WriteLine("unable to parse your input");
                return "Not Consecutive";
            }
        }

        static void ProblemTwo()
        {
            System.Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = System.Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }
            try {
                var ParsedInput = Array.ConvertAll(input.Split("-"), int.Parse);
                var DedupedInput = ParsedInput.Distinct().ToArray();
                if (DedupedInput.Length != ParsedInput.Length)
                {
                    System.Console.WriteLine("Duplicates");
                } else
                {
                    System.Console.WriteLine("No Duplicates");
                }

            } catch (Exception)
            {
                System.Console.WriteLine("Unable to parse your response");
            }
        }

        static void ProblemThree()
        {
            System.Console.Write("Enter a time value in military time: ");
            var input = System.Console.ReadLine();
            try {
                DateTime.ParseExact(input, "HH:mm", CultureInfo.InvariantCulture);
            } catch (Exception)
            {
                System.Console.WriteLine("Invalid Time.");
            }
        }

        static void ProblemFour()
        {
            System.Console.Write("Enter a few words separated by a space: ");
            var input = System.Console.ReadLine();
            try {
                var ParsedInput = input.Split(" ");
                var FinishedPascalCase = "";
                foreach (var word in ParsedInput)
                {
                    if (!String.IsNullOrWhiteSpace(word))
                    {
                        var CleanedWord = word.Trim();
                        FinishedPascalCase += char.ToUpper(CleanedWord[0]) + CleanedWord.Substring(1);
                    }
                }
                System.Console.WriteLine(FinishedPascalCase);

            } catch (Exception)
            {
                System.Console.WriteLine("Unable to parse your input");
            }
        }
        static int ProblemFive()
        {
            System.Console.Write("Enter an english word: ");
            var input = System.Console.ReadLine();
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var NumberVowels = 0;
            foreach (var letter in input)
            {
                if (vowels.Contains(letter))
                {
                    NumberVowels++;
                }
            }
            return NumberVowels;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var fullName = "Mosh Hamedani";
            System.Console.WriteLine("Trim: '{0}'", fullName.Trim());
            System.Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstname = fullName.Substring(0, index);
            var lastname = fullName.Substring(index + 1);

            var names = fullName.Split(' ');
            System.Console.WriteLine(names[0]);
            System.Console.WriteLine((names[1]));

            var fullFirstName = fullName.Replace("Mosh", "Moshfegh");

            var str = "25";
            var age = Convert.ToInt32(str);

            System.Console.WriteLine(ProblemOne());

            ProblemTwo();
            ProblemThree();
            ProblemFour();
            System.Console.WriteLine(ProblemFive());
        }
    }
}
