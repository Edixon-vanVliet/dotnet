using System;
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

        static void Main(string[] args)
        {
            RunTimesTable();
        }
    }
}
