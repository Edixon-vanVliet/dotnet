using System;
using System.Text.RegularExpressions;

using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Write("Enter a regular expression (or press ENTER to use the default): ");
                string regex = ReadLine();

                if (string.IsNullOrEmpty(regex))
                {
                    regex = "[1-9]+";
                }

                Write("Enter some input: ");
                string input = ReadLine();

                var regularExpression = new Regex(regex);

                WriteLine($"{input} matches {regex}? {regularExpression.IsMatch(input)}");

                WriteLine("Press ESC to end or any key to try again.");
            }
            while (ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
