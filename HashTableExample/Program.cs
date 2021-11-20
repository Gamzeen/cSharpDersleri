using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashTable
            //oluşturma
            Hashtable cities = new Hashtable();
            //ekleme
            cities.Add(54, "Sakarya");
            cities.Add(34,"İstanbul");
            cities.Add(53,"Rize");
            cities.Add(35,"İzmir");

            //dolaşım
            Console.WriteLine("LOOP");
            foreach (DictionaryEntry item in cities)
            {
                Console.WriteLine($"Key: {item.Key,-5} Value: {item.Value,-10}");
            }
            Console.WriteLine("");

            //silme
            cities.Remove(35);

            //dolaşma
            Console.WriteLine("Loop After Remove");
            foreach (DictionaryEntry item in cities)
            {
                Console.WriteLine($"Key: {item.Key,-5} Value: {item.Value,-10}");
            }
            Console.WriteLine("");
            bool result = cities.Contains(83);
            Console.WriteLine($"Cities contain: {result} ");

            Console.ReadLine();
        }
    }
}
