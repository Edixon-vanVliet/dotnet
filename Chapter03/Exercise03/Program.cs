using System;
using static System.Console;

/// <summary>
/// Simulated FizzBuzz game counting up to 100
/// when the count is divisible by three replace with the word fizz
/// when the count is divisible by five replace with the word buzz
/// when the count is divisible by three and five replace with the word fizzbuzz
/// </summary>

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz && buzz)
                {
                    Write($"fizzbuzz, ");
                }
                else if (fizz)
                {
                    Write($"fizz, ");
                }
                else if (buzz)
                {
                    Write($"buzz, ");
                }
                else
                {
                    Write($"{i}, ");
                }
            }
        }
    }
}
