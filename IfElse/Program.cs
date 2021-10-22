using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            if (20 > 18)
            {
                Console.WriteLine("20 sayısı 18'den büyüktür.");
            }

            int x = 2;
            int y = 3;
            if (x < y)
            {
                Console.WriteLine("x sayısı y'den küçüktür.");
            }

            int time = 21;

            if (time < 20)
            {
                Console.WriteLine("time 20'den küçüktür.");
            }
            else
            {
                Console.WriteLine("time 20'den büyüktür");
            }

            int time1 = 22;

            if (time1 < 10)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time1 == 22)
            {
                Console.WriteLine("Saat " + DateTime.Now);
            }
            else if (time1 < 22)
            {
                Console.WriteLine("Saat " + DateTime.Now);
            }
            else
            {
                Console.WriteLine("iyi geceler Bacımmm");
            }

            //Short Hand If...Else(Ternary Operator)
            int TernaryValue = 35;
            string sonuc = (TernaryValue > 15) ? "TernaryValue 15'ten büyüktür" : "TernaryValue 15'ten küçüktür";
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
