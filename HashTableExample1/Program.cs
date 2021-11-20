using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample1
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("Old Title: "+ input);

            input = input.ToLower();
            Console.WriteLine("ToLower Title: "+input);

            Hashtable characterSet = new Hashtable
            {
                { 'ç', 'c' },
                { 'ğ', 'g' },
                { 'ö', 'o' },
                { 'ş', 's' },
                { 'ü', 'u' },
                { 'ı', 'i' },
                { '.', '-' },
                { '\'', '-' },
                { ' ', '-' }
            };

            foreach (DictionaryEntry item in characterSet)
            {
                //Console.WriteLine($"item.Key: {item.Key} item.Value: {item.Value}");
                input= input.Replace((char)item.Key,(char)item.Value);
            }
            string output= input.TrimEnd('-');
            Console.WriteLine("Last Title :"+ output);
            Console.ReadLine();
        }
    }
}
