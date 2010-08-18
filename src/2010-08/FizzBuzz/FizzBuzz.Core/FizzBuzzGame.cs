using System;

namespace FizzBuzz.Core
{
    public class FizzBuzzGame
    {
        public string Evaluate(int i)
        {
            var returnValue = String.Empty;

            if (i % 3  == 0)
            {
                returnValue = "Fizz";
            }

            if (i % 5 == 0)
            {
                returnValue += "Buzz";
            }

            return returnValue;
        }
    }
}