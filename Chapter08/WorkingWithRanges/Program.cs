using System;
using static System.Console;

namespace WorkingWithRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Samantha Jones";
            int indexOfSpace = name.IndexOf(' ');

            string firstName = name.Substring(0, indexOfSpace);
            string lastName = name.Substring(indexOfSpace + 1);

            WriteLine($"First name: {firstName}, Last name: {lastName}");
        }
    }
}
