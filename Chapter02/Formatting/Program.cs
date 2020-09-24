using System;

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
        }
    }
}
