using System;
using SharpPad;
using System.Threading.Tasks;
using static System.Console;

namespace Dumping
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var complexObject = new
            {
                FirstName = "Edixon",
                Birthday = new DateTime(1996, 3, 27),
                Friends = new[] { "Bleyly", "Cesar", "Chris" }
            };

            WriteLine($"Dumping {nameof(complexObject)} to SharpPad.");

            await complexObject.Dump();
        }
    }
}
