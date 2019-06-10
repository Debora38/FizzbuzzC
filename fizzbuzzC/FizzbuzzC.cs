using System;

namespace fizzbuzzC
{
    public class FizzbuzzC
    {
        static void Main()
        {

        }

        public object Fizz(int num)
        {
            if (num % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return num;
            }
        }
    }
}
