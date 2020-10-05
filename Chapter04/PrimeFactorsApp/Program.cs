using System;
using PrimeFactorsLib;
using static System.Console;

namespace PrimeFactorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumber;

            do
            {
                Write("Enter a number between 0 and 1000: ");

                isNumber = int.TryParse(ReadLine(), out int number);

                if (isNumber)
                {
                    WriteLine($"Prime factors: {Primes.PrimeFactors(number)}");
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }
    }
}
