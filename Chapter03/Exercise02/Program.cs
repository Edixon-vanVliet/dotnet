﻿using System;
using static System.Console;

/// <summary>
/// What code could you add to warn us about the problem?
/// </summary>

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++)
                    {
                        WriteLine(i);
                    }
                }
            }
            catch (OverflowException)
            {
                WriteLine($"Byte i overflowed");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
        }
    }
}
