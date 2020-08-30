using System;
using System.IO;

namespace files
{
    class Program
    {
        static void ProblemOne(string path) {
            try
            {
                var text = File.ReadAllText(path);
                var removed_newline = text.Replace(Environment.NewLine, " ");
                var split_text = removed_newline.Split(" ");

                System.Console.WriteLine(split_text.Length);
            } catch (Exception)
            {
                System.Console.WriteLine("Unable to read the file at the given path");
            }
        }
        static void ProblemTwo(string path)
        {
            var MaxLength = 0;
            string LongestWord = "";
            var text = File.ReadAllText(path);
            var removed_newline = text.Replace(Environment.NewLine, " ");
            var split_text = removed_newline.Split(" ");
            foreach (var word in split_text)
            {
                if (word.Length > MaxLength)
                {
                    MaxLength = word.Length;
                    LongestWord = word;
                }
            }
            System.Console.WriteLine("Max Length: " + MaxLength);
            System.Console.WriteLine("Longest Word: " + LongestWord);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ProblemOne("./test_file.txt");
            ProblemTwo("./test_file.txt");
        }
    }
}
