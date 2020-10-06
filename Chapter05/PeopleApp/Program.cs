using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var edixon = new Person();
            edixon.Name = "Edixon van Vliet";
            edixon.DateOfBirth = new DateTime(1996, 3, 27);

            WriteLine(
                "{0} was born on {1:dddd, d MMMM yyyy}",
                edixon.Name,
                edixon.DateOfBirth
            );

            edixon.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

            WriteLine(
                "{0}'s favorite wonder is {1}. It's integer is {2}.",
                edixon.Name,
                edixon.FavoriteAncientWonder,
                (int)edixon.FavoriteAncientWonder
            );

            edixon.BucketList =
                WondersOfTheAncientWorld.HangingGardensOfBabylon
                | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

            WriteLine($"{edixon.Name}'s bucket list is {edixon.BucketList}");

            edixon.Children.Add(new Person { Name = "Alfred" });
            edixon.Children.Add(new Person { Name = "Zoe" });

            WriteLine($"{edixon.Name} has {edixon.Children.Count} children:");

            foreach (Person child in edixon.Children)
            {
                WriteLine($"  {child.Name}");
            }

            BankAccount.InterestRate = 0.012m;

            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400m;

            WriteLine(
                "{0} earned {1:c} interest.",
                jonesAccount.AccountName,
                jonesAccount.Balance * BankAccount.InterestRate
            );

            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98m;

            WriteLine(
                "{0} earned {1:c} interest.",
                gerrierAccount.AccountName,
                gerrierAccount.Balance * BankAccount.InterestRate
            );

            WriteLine($"{edixon.Name} is a {Person.Species}");

            WriteLine($"{edixon.Name} was born on {edixon.HomePlanet}");

            var blankPerson = new Person();

            WriteLine(format:
                "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                blankPerson.Name,
                blankPerson.HomePlanet,
                blankPerson.Instantiated
            );

            var gunny = new Person("Gunny", "Mars");

            WriteLine(
                "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                gunny.Name,
                gunny.HomePlanet,
                gunny.Instantiated
            );

            edixon.WriteToConsole();
            WriteLine(edixon.GetOrigin());

            (string, int) fruit = edixon.GetFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            var fruitNamed = edixon.GetNamedFruit();
            WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

            var thing2 = (edixon.Name, edixon.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children.");

            (string fruitName, int fruitNumber) = edixon.GetFruit();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

            WriteLine(edixon.SayHello());
            WriteLine(edixon.SayHello("Emily"));

            WriteLine(edixon.OptionalParameters());

            WriteLine(edixon.OptionalParameters("Jump!", 98.5));
        }
    }
}
