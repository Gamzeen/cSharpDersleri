using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    public static class PrimeNumber
    {
        public static void CheckNumber(int number)
        {
            int control = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    control++;
                }
            }
            if (control != 0)
            {
                Console.WriteLine("asal sayı değil");
            }
            else
            {
                Console.WriteLine("asal sayi");
            }


        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }



    }
}
