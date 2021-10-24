using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    public class Book
    {
        public static void GetName()
        {
            Console.WriteLine("Book Name is Shrek");
        }

        public void GetName1()
        {
            Console.WriteLine("Book Name is Shrek");
        }

       
    }
}
