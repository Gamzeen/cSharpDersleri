using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }

        public void GetName()
        {
            Console.WriteLine(Name);
        }

        public void GetName1(string name)
        {
            Console.WriteLine(name);
        }

        public void Eat()
        {
            Console.WriteLine("Eat Something!");
        }

        public void Backward()
        {
            Console.WriteLine("Go to Backward !");
        }

        public void Forward()
        {
            Console.WriteLine("Go to Forward !");
        }
    }
}
