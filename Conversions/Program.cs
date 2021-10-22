using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //String to integer
            string strValue1 = "33";
            string strValue2 = "10";
            int intValue1 = Convert.ToInt32(strValue1);
            int intValue2 = Convert.ToInt32(strValue2);
            int sumStrtoInt = intValue1 + intValue2;

            Console.WriteLine("String to Integer: " + sumStrtoInt);

            //Integer to String
            int intValue3 = 11;
            int intValue4 = 55;
            string strValue3 = Convert.ToString(intValue3);
            string strValue4 = Convert.ToString(intValue4);

            Console.WriteLine("Integer to String: " + strValue3 + strValue4);


            //Double to Int
            double doubleValue1 = 3.14;
            double doubleValue2 = 7.2;
            int intValue5 = Convert.ToInt32(doubleValue1);
            int intValue6 = Convert.ToInt32(doubleValue2);
            int sumDoubletoInt = intValue5 + intValue6;

            Console.WriteLine("Double to Integer: " + sumDoubletoInt);

            //Integer to Double
            int intValue7 = 45;
            int intValue8 = 65;
            double doubleValue3 = Convert.ToDouble(intValue7);
            double doubleValue4 = Convert.ToDouble(intValue8);
            double sumInttoDouble = doubleValue3 + doubleValue4;

            Console.WriteLine("Integer to Double: " + sumInttoDouble);











            Console.ReadLine();
        }
    }
}
