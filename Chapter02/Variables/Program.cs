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
        }
    }
}
