using System;

namespace fizzbuzzC
{
    public class FizzbuzzC
    {
        static void Main()
        {

        }

        public object FizzBuzz(int num)
        {
            if (num % 15 == 0)
            {
                return "Fizzbuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return num;
            }
        }
    }
}
