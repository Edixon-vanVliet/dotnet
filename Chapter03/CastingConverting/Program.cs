using System;
using static System.Console;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a; // an int can be safely cast into a double

            WriteLine(b);
        }
    }
}
