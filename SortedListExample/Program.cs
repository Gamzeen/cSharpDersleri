using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedList()
            {
                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"},
                {8,"Sekiz"},
                {5,"Beş"},
                {11,"Onbir"},
                {9,"Dokuz"},
                {6,"Altı"},
                {12,"Oniki"},
                {95,"Doksan Beş"},
                {110,"Yüz On"},
                {29,"Yirmi Dokuz"},
                {16,"On Altı"},
                {112,"Yüz Oniki"},
                {14,"Ondört"},
                {114,"Yüz Ondört"}
            };
            list.Add(4,"Dört");

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"Liste: {item.Key} {item.Value}");
            }

            foreach (var item in list.GetValueList())
            {
                Console.WriteLine($"Key List: {item}");
            }
            foreach (var item in list.GetValueList())
            {
                Console.WriteLine($"Value List: {item}");
            }

            Console.WriteLine($"Kapasite: {list.Capacity}");
            Console.WriteLine($"Eleman Sayısı: {list.Count}");
            list.TrimToSize();
            Console.WriteLine($"Capasite after Trim: {list.Capacity}");
            Console.ReadLine();
        }
    }
}
