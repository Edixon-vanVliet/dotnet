﻿using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This the {number} times table:");

            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }

            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;

            do
            {
                Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0m;

            switch (twoLetterRegionCode)
            {
                case "CH": // Switzerland
                    rate = 0.08m;
                    break;
                case "DK": // Denmark
                case "NO": // Normway
                    rate = 0.25m;
                    break;
                case "GB": // United Kingdom
                case "FR": // France
                    rate = 0.2m;
                    break;
                case "HU": // Hungary
                    rate = 0.27m;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0m;
                    break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maryland
                case "VA": // Virginia
                    rate = 0.05m;
                    break;
                case "CA": // California
                    rate = 0.0825m;
                    break;
                default: // most US states
                    rate = 0.06m;
                    break;
            };

            return amount * rate;
        }

        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();

            Write("Enter a two-letter region code: ");
            string region = ReadLine().ToUpper();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);

                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }

        /// <summary>
        /// Pass a 32-bit integer and it will be 
        /// converted to its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value
        /// eg. 1, 2, 3, and so on</param>
        /// <returns>Number as a ordinal value 
        /// eg. 1st, 2nd, 3rd, and so on</returns>
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    string numberAsText = number.ToString();
                    char lastDigit = numberAsText[numberAsText.Length - 1];
                    string suffix = string.Empty;
                    switch (lastDigit)
                    {
                        case '1':
                            suffix = "st";
                            break;
                        case '2':
                            suffix = "nd";
                            break;
                        case '3':
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }
                    return $"{number}{suffix}";
            }
        }

        static void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
            WriteLine();
        }

        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static void RunFactorial()
        {
            bool isNumber;

            do
            {
                Write("Enter a number: ");

                isNumber = int.TryParse(ReadLine(), out int number);

                if (isNumber)
                {
                    WriteLine($"{number:n0}! = {Factorial(number):n0}");
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }

        static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCalculateTax();
            // RunCardinalToOrdinal();
            RunFactorial();
        }
    }
}
