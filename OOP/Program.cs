using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCarOverload = new Car();
            Car newCar = new Car("Blue", "Ford Ranger", 4);
            newCar.GoToForward();


            newCar.GetProperties();
            ResultDeneme md = newCar.MethodDeneme();
            Console.WriteLine(md.Value1);

            Console.ReadLine();
        }
    }
}
