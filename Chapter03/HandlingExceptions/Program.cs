using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age? ");

            string input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);

                WriteLine($"You are {age} years old.");
            }
            catch
            {
            }

            WriteLine("After parsing");
        }
    }
}
