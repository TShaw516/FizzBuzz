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
            
            if (IsMultipleOfFifteen(num))
            {
                return "Fizzbuzz";
            }
            if (IsMultipleOfThree(num))
            {
                return "Fizz";
            }
            if (IsMultipleOFFive(num))
            {
                return "Buzz";
            }
            if (string.IsNullOrEmpty(count))
                count = num.ToString();
            return count;
        }

        public bool IsMultipleOfThree(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }

        public bool IsMultipleOFFive(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }

        public bool IsMultipleOfFifteen(int numberToCheck)
        {
            return numberToCheck % 15 == 0;
        }
    }
}
