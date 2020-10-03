using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a; // an int can be safely cast into a double

            WriteLine(b);

            double c = 9.8;
            int d = (int)c; // need to cast explicitly or else compiler gives an error

            WriteLine(d); // d is 9 losing the .8 part

            long e = 10;
            int f = (int)e;

            WriteLine($"e is {e:n0} and f is {f:n0}");

            e = long.MaxValue;
            f = (int)e;

            WriteLine($"e is {e:n0} and f is {f:n0}");

            double g = 9.8;
            int h = ToInt32(g);

            WriteLine($"g is {g} and h is {h}");
        }
    }
}
