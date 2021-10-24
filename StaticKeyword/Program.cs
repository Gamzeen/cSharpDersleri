using System;

namespace StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.GetName1();
            Book.GetName();

            //PrimeNumber.CheckNumber(524570000);


            bool result = PrimeNumber.IsPrime(524570000);

            if (result)
            {
                Console.WriteLine("Prime Number");
            }

            else
            {
                Console.WriteLine("İt is not Prime Number");
            }

            Console.Read();
        }
    }
}
