using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
         


            var dog = new Dog();
            dog.Name = "Bobo";
            dog.GetName();
            dog.GetName1("Bobo1");
            dog.Barking();
            dog.Eat();

            Console.WriteLine("--------------");

            var bird = new Bird();
            bird.Name = "Kiki";
            bird.GetName();
            bird.Tweet();

            Console.ReadLine();
        }
    }
}
