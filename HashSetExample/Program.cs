using System;
using System.Collections;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet
            //Oluşturma
            var vocals = new HashSet<char>()
            {
                'a','e','ı','i','o','u','ü'
            };

            WriteCollection(vocals);
            //Ekleme
            vocals.Add('ö');
            WriteCollection(vocals);

            //Silme
            vocals.Remove('ö');
            WriteCollection(vocals);
            vocals.Add('ö');

            var alphabet = new List<char>();
            for (int i = 97; i < 123; i++)
                alphabet.Add((char)i);
            alphabet.ForEach(k => Console.WriteLine(k));
            WriteCollection(alphabet);

            //Sadece Türkçe'de kullanılan sesli harfleri almak
            //vocals.ExceptWith(alphabet);
            //WriteCollection(vocals);

            //Sadece Türkçe'de kullanılan sesli harflerle 26 harfi birleştirmek
            //vocals.UnionWith(alphabet);
            //WriteCollection(vocals);

            //Sadece Türkçe'de kullanılan sesli harflerle 26 harfin kesişimi
            //vocals.IntersectWith(alphabet);
            //WriteCollection(vocals);

            //Kesişim dışı harfler
            vocals.SymmetricExceptWith(alphabet);
            WriteCollection(vocals);

            Console.ReadKey();
        }

        static void WriteCollection(IEnumerable collection)
        {
            Console.WriteLine();
            int i = 0;
            foreach (var item in collection)
            {
                Console.Write($"{item,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Eleman Sayisi:{0}", i);
            Console.WriteLine();

        }
    }
}
