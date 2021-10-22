using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte
            byte byteValue1 = 5;
            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;

            //short
            short shortValue1 = -5;
            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;

            //integer
            int intValue = 758668464;
            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;

            //float
            float floatValue = 5.4f;//bu değişken ilk olarak double veri tipinde gelir ve float oladuğunu
                                    //belirtmek için sayının sonuna f konur ve bu işleme cast denir
            float floatMinValue = float.MinValue;
            System.Single floatMaxValue = float.MaxValue;//float anahtar sözcüğü system.single için bir diğer addır.

            //double
            double doubleValue = 5.4;
            //Console.WriteLine(doubleValue.GetType());
            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;

            //char
            char charValue = (char)112;
            //Console.WriteLine(charValue);
            int charMinValue = char.MinValue;
            int charMaxValue = char.MaxValue;

            //string
            string strValue = "string";

            //boolean
            bool boolValue = true;

            //var tip1 = 10.6;

            //output
            Console.WriteLine($"byte Value:{byteValue1} Max Byte Value:{byteMinValue} Min Byte Value:{byteMaxValue}");
            Console.WriteLine($"Short value:{shortValue1} Min Short value:{shortMinValue} Max Short value:{shortMaxValue}");
            Console.WriteLine($"integer Value: {intValue} Min integer Value:{intMinValue} Max integer Value:{intMaxValue}");
            Console.WriteLine($"float Value:{floatValue} Min Float Value:{floatMinValue} Max Float Value:{floatMaxValue} ");
            Console.WriteLine($"double Value:{doubleValue} Min Double Value:{doubleMinValue} Max Double Value:{doubleMaxValue} ");
            Console.WriteLine($"char Value:{charValue} Min Char Value:{charMinValue} Max Char Value:{charMaxValue}");
            Console.WriteLine($"string Value:{strValue}");
            Console.WriteLine($"Bool Value:{boolValue}");
           

            int s = SayiHesap();

            
            DegerAl((byte)s);

            Console.ReadLine();


        }

        static public void DegerAl(byte value)
        {
            Console.WriteLine(value);
        }

        static public int SayiHesap()
        {
            return 500;
        }
    }
}
