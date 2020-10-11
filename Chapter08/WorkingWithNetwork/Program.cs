using System;
using System.Net;

using static System.Console;

namespace WorkingWithNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a valid web address: ");
            string url = ReadLine();

            if (string.IsNullOrEmpty(url))
            {
                url = "https://world.episerver.com/cms/?q=pagetype";
            }
        }
    }
}
