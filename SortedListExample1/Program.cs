using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new SortedList()
            {
                {"Önsöz",1},
                {"Döngüler",10},
                {"İfadeler",15},
                {"Sorgular",5},
                {"Sorted List",17 }
            };
            Console.WriteLine("İçindekiler");
            Console.WriteLine(new string('-',20));
            Console.WriteLine($"{"Başlıklar",-30} {"Sayfa",-20}");
            foreach (DictionaryEntry item in book)
            {
                Console.WriteLine($"{item.Key,-30} {item.Value,-20}");
            }

            Console.ReadLine();
        }
    }
}
