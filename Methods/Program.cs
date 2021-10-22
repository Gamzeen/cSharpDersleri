using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteName("Gamzişko");
            GetTime();
            int result = SumValue(1, 2);
            Console.WriteLine("result", result);

            string fullName = FirstAndLastName("Gamzişko", "Lovo");
            Console.WriteLine(fullName);

            string[] vegitables = GetVegitables();
            foreach (string item in vegitables)
            {
                Console.WriteLine(item);
            }

            int[] gettingParameters = GetParameter(3, 5, 7);
            for (int i = 0; i < gettingParameters.Count(); i++)
            {
                Console.WriteLine($"getting Parameters idx:{i} value:{gettingParameters[i]}");
            }

            bool resultOddOrEven = GetOddOrEven(10);
            if (resultOddOrEven == true)
            {
                Console.WriteLine($"Entered Number is Even ");
            }
            else
            {
                Console.WriteLine($"Entered Number is Odd");
            }

            Console.ReadLine();
        }

        static void WriteName(string name)
        {
            Console.WriteLine(name);
        }
        static void GetTime()
        {
            Console.WriteLine(DateTime.Now);
        }

        static int SumValue(int value1, int value2)
        {
            return value1 + value2;
        }

        static string FirstAndLastName(string fName, string lName)
        {
            string name = fName + " " + lName;
            return name;
        }

        static string[] GetVegitables()
        {
            string[] vegeterianVagitables = { "Banana", "Apple", "Pineapple", "Avacado" };
            return vegeterianVagitables;
        }

        static int[] GetParameter(int parameter1, int parameter2, int parameter3)
        {
            int[] parameters = new int[] { parameter1, parameter2, parameter3 };
            return parameters;
        }

        static bool GetOddOrEven(int value)
        {
            if (value % 2 == 0) { return true; }

            return false;

        }
    }
}
