using System;
using System.Reflection;

using static System.Console;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Assembly metadata:");
            Assembly assembly = Assembly.GetEntryAssembly();

            WriteLine($"  Full name: {assembly.FullName}");
            WriteLine($"  Location: {assembly.Location}");

            var attributes = assembly.GetCustomAttributes();
            WriteLine($"  Attributes:");
            foreach (Attribute attribute in attributes)
            {
                WriteLine($"    {attribute.GetType()}");
            }

            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            WriteLine($" Version: {version.InformationalVersion}");
            var company = assembly.GetCustomAttribute
             <AssemblyCompanyAttribute>();
            WriteLine($" Company: {company.Company}");
        }

        [Coder("Edixon van Vliet", "10 October 2020")]
        static void DoStuff()
        {

        }
    }
}
