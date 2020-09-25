using System;
using static System.Console;

/// <summary>
/// Exercise that outputs the number of bytes in memory that each of the
/// following number types use, and the minimum and maximum values they can
/// have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double and
/// decimal
/// </summary>

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = new String('-', 72);

            // header
            WriteLine(line);
            WriteLine(
                format: "{0,-7} {1,-2} {2,15} {3,30}",
                "Type",
                "Byte(s) of memory",
                "Min",
                "Max"
            );
            WriteLine(line);
        }
        
        static string FormatString(string name, int bytes, object minValue, object MaxValue)
        {
            return String.Format(
                format: "{0,-7} {1,-2} {2,30} {3,30}",
                name,
                bytes,
                minValue,
                MaxValue
            );
        }
    }
}
