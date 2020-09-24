using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.75; // storing a double in an object
            object name = "Edixon"; // storing a string in an object

            Console.WriteLine($"{name} is {height} metres tall.");

            // int lenght1 = name.Length; // gives compile error
            int length2 = ((string)name).Length; // tell compiler it is a string

            Console.WriteLine($"{name} has {length2} characters.");

            // storing a string in a dynamic object
            dynamic anotherName = "Edixon";

            // this compiles but would throw an exception at run-time
            // if you later store a data type that does not have a 
            // property named Length
            int length = anotherName.Length;

            int population = 66_000_000; // 66 million in UK
            double weight = 1.88; // in kilograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; // strings use double-quotes
            char letter = 'Z'; // chars use single-quotes
            bool happy = true; // Booleans have value of true or false
        }
    }
}
