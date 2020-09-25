using System;
using static System.Console;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments.");

            foreach (string arg in args)
            {
                WriteLine(arg);
            }

            if (args.Length < 4)
            {
                WriteLine("You must specify two colors and dimensions, eg.");
                WriteLine("dotnet run red yellow 80 40");

                return;
            }
        }
    }
}
