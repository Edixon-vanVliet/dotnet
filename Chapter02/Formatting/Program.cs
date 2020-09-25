﻿using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35m;

            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: numberOfApples * pricePerApple
            );

            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: numberOfApples * pricePerApple
            );

            // WriteToFile(formatted); // writes the string into a file

            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count"
            );

            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount
            );

            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );

            Console.Write("Type your first name and press ENTER: ");
            string firstName = Console.ReadLine();

            Console.Write("Type you age and press ENTER: ");
            string age = Console.ReadLine();

            Console.WriteLine($"Hello {firstName}, you look good for {age}.");
        }
    }
}
