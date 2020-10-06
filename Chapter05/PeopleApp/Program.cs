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
        }
    }
}
