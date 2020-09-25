using System;
using static System.Console;
using System.Collections.Generic;

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
            // array with all the number types and their keyword
            KeyValuePair<string, string>[] numberTypes = {
                new KeyValuePair<string, string>("sbyte", "System.SByte"),
                new KeyValuePair<string, string>("byte", "System.Byte"),
                new KeyValuePair<string, string>("short", "System.Int16"),
                new KeyValuePair<string, string>("ushort", "System.UInt16"),
                new KeyValuePair<string, string>("int", "System.Int32"),
                new KeyValuePair<string, string>("uint", "System.UInt32"),
                new KeyValuePair<string, string>("long", "System.Int64"),
                new KeyValuePair<string, string>("ulong", "System.UInt64"),
                new KeyValuePair<string, string>("float", "System.Single"),
                new KeyValuePair<string, string>("double", "System.Double"),
                new KeyValuePair<string, string>("decimal", "System.Decimal"),
            };

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
