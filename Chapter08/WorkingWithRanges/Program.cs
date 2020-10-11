using System;
using static System.Console;

namespace WorkingWithRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Samantha Jones";
            int lengthOfFirst = name.IndexOf(' ');
            int lengthOfLast = name.Length - name.IndexOf(' ') - 1;

            string firstName = name.Substring(0, lengthOfFirst);
            string lastName = name.Substring(lengthOfFirst + 1, lengthOfLast);

            WriteLine($"First name: {firstName}, Last name: {lastName}");

            ReadOnlySpan<char> nameAsSpan = name.AsSpan();
            var firstNameSpan = nameAsSpan[..lengthOfFirst];
            var lastNameSpan = nameAsSpan[^lengthOfLast..];

            WriteLine(
                "First name: {0}, Last name: {1}",
                firstNameSpan.ToString(),
                lastNameSpan.ToString()
            );
        }
    }
}
