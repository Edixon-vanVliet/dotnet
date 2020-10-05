using System;
using System.Linq;

namespace PrimeFactorsLib
{
    public class Primes
    {
        int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };

        /// <summary>
        /// Pass a 32-bit integer and it will return its prime factors
        /// </summary>
        /// <param name="number">Number is the value you want the prime factors 
        /// of eg. 50</param>
        /// <returns>return the prime factors of number eg. 5 x 5 x 2</returns>
        public string PrimeFactors(int number)
        {
            if (primeNumbers.Contains(number))
            {
                return number.ToString();
            }

            foreach (int prime in primeNumbers)
            {
                if (number % prime == 0)
                {
                    return $"{PrimeFactors(number / prime)} x {prime}";
                }
            }

            return string.Empty;
        }
    }
}
