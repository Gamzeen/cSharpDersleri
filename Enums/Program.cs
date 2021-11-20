using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            Level level = Level.High;
            Level level1 = (Level)1;
            switch (level)
            {
                case 0:
                    Console.WriteLine("Level Low"); 
                    break;
                case Level.Medium:
                    Console.WriteLine("Level Medium"); 
                    break;
                case (Level)2:
                    Console.WriteLine("Level High"); 
                    break;
                
            }
            Console.ReadLine();
        }
    }
}
