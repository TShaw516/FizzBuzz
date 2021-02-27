using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string Get(int num)
        {
            string count = string.Empty;
            
            if (FizzBuzzCheck(num, 15))
            {
                return "Fizzbuzz";
            }
            if (FizzBuzzCheck(num, 3))
            {
                return "Fizz";
            }
            if (FizzBuzzCheck(num, 5))
            {
                return "Buzz";
            }
            if (string.IsNullOrEmpty(count))
                count = num.ToString();
            return count;
        }

        public bool FizzBuzzCheck(int numberToCheck, int numberDivisor)
        {
            return numberToCheck % numberDivisor == 0;
        }
    }
}
