using System;
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
        }
    }
}
