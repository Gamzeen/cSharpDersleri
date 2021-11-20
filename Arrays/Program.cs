using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lInt = new List<Person>();
            lInt.Add(new Person() { Name = "Gamnze"}); 

            string[] passengers = { "John", "Michael", "Sara", "Ester", "Angelina" };
            string[] pass2 = new string[] { "", "", "", "" };

            for (int i = 0; i < passengers.Length; i++)
            {
                Console.WriteLine($"index:{i} item:{passengers[i]} ");
                //"index:1 item:jonh
            }

            int[] notes = { 74, 5, 21, 36 };
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i]==5)
                {
                    Console.WriteLine("değer 5 e eşit");
                }
            }


            //foreach
            foreach(string item in passengers)
            {
                Console.WriteLine(item);
            }


            string[] cars = new string[4] { "porsche","ferrari","volvo","honda" };
            Console.WriteLine(cars.Length);
            Console.WriteLine(cars.Count());
            Console.WriteLine(cars.First());


            Console.ReadLine();




        }
    }
}
