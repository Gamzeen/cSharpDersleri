using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCtor
{
    public class Person
    {
        private int _personId { get; set; }

        private string _name { get; set; }

        private string _surname { get; set; }

        private static int _maas { get; set; }


        static Person()
        {
            _maas = 2500;//static constructor altından bir dğeişkene ulaşmak için
                         //o property'nin de static olması gerekir.
                         //bknz( private static int _maas { get; set; })
        }
        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Person Name : {_name} {_surname} ");
        }
        
        public void Income(int value)
        {
            Console.WriteLine("Zamlı maaş" + (_maas+value));
             
        }


    }
}
