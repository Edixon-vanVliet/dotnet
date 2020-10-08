using System;
using static System.Console;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long.");

            WriteLine($"First char is {city[0]} and third is {city[2]}.");

            string cities = "Paris,Berlin,Madrid,New York";

            string[] citiesArray = cities.Split(',');

            foreach (string item in citiesArray)
            {
                WriteLine(item);
            }

            string fullName = "Alan Jones";
            int indexOfTheSpace = fullName.IndexOf(' ');

            string firstName = fullName.Substring(0, indexOfTheSpace + 1);
            string lastName = fullName.Substring(indexOfTheSpace + 1);

            WriteLine($"{lastName}, {firstName}");

            string company = "Microsoft";
            bool startWithM = company.StartsWith('M');
            bool containsN = company.Contains('N');

            WriteLine($"Starts with M: {startWithM}, contains an N: {containsN}");
        }
    }
}
