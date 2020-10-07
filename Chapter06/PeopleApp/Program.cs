﻿using System;
using Packt.Shared;

using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            // call instance method
            var baby1 = mary.Procreate(harry);

            // call static method
            var baby2 = Person.Procreate(harry, jill);

            // call an operator
            var baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count} children");
            WriteLine($"{mary.Name} has {mary.Children.Count} children");
            WriteLine($"{jill.Name} has {jill.Children.Count} children");

            WriteLine(
                $"{harry.Name}'s first child is named \"{harry.Children[0].Name}\"."
            );

            WriteLine($"5! is {Person.Factorial(5)}");

            harry.Shout += Harry_Shout;

            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            Person[] people =
            {
                new Person {Name = "Simon"},
                new Person {Name = "Jenny"},
                new Person {Name = "Adam"},
                new Person {Name = "Richard"}
            };

            WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("Use Person's IComparable implementation to sort:");
            Array.Sort(people);

            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("Use PersonComparer's IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());

            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            var t1 = new Thing();
            t1.Data = 42;

            WriteLine($"Thing with an integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";

            WriteLine($"Thing with a string: {t2.Process("apple")}");

            var gt1 = new GenericThing<int>();
            gt1.Data = 42;

            WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";

            WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            string number1 = "4";
            WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");

            byte number2 = 3;
            WriteLine($"{number2} squared is {Squarer.Square(number2)}");

            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}
