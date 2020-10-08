using System;
using System.Numerics;

using static System.Console;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var largest = ulong.MaxValue;

            WriteLine($"{largest,40:n0}");
        }
    }
}
