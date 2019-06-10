using System;

namespace fizzbuzzC
{
    public class FizzbuzzC
    {
        static void Main()
        {

        }

        public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
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