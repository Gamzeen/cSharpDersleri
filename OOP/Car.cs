using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Car
    {

        private string _color;
        private string _markaName;
        private int _wheelCount;

        public Car()
        {
            _color = "Red";
            _markaName = "Fiat";
            _wheelCount = 3;

            Console.WriteLine("Araba Rengi: " + _color);
            Console.WriteLine("Araba Markası:" + _markaName);
            Console.WriteLine("Tekerlek Sayısı: " + _wheelCount);
        }


        public Car(string color, string markaName, int wheelCount)
        {
            _color = color;
            _markaName = markaName;
            _wheelCount = wheelCount;
        }

        public void GetProperties()
        {
            Console.WriteLine("Araba Rengi: " + _color);
            Console.WriteLine("Araba Markası:" + _markaName);
            Console.WriteLine("Tekerlek Sayısı: " + _wheelCount);
        }

        public void GoToForward()
        {
            Console.WriteLine("İleri gidiliyor.");
        }

        public void GoToBackward()
        {
            Console.WriteLine("Geri gidiliyor.");
        }

        public ResultDeneme MethodDeneme()
        {
            var result = new ResultDeneme();
            result.Value1 = 1;
            result.Value2 = "test";

            return result;

 
        }
    }
}
