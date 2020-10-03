using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            string password = string.Empty;

            do
            {
                Write("Enter password: ");
                password = ReadLine();
            }
            while (password != "Pa$$w0rd");

            WriteLine("Correct!");
        }
    }
}
