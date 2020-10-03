using System;
using static System.Console;

/// <summary>
/// asks the user for two numbers in the range 0-255 and then divides 
/// the first number by the second
/// </summary>

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1, number2;

            try
            {
                Write("Enter a number between 0 and 255: ");
                number1 = byte.Parse(ReadLine());

                Write("Enter a number between 0 and 255: ");
                number2 = byte.Parse(ReadLine());

                WriteLine($"{number1} divided by {number2} is {number1 / number2}");
            }
            catch (OverflowException)
            {
                WriteLine("number to big or to small.");
            }
            catch (FormatException)
            {
                WriteLine("Not a valid number.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}.");
            }
        }
    }
}
