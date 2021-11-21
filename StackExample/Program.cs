using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterStack();
        }
        static void CharacterStack()
        {
            var charStack = new Stack<char>();
            charStack.Push('A');
            charStack.Push('B');
            charStack.Push('C');

            Console.WriteLine($"Char Stack is : {charStack.Count}");

            for (int i = 60; i < 95; i++)
            {
                charStack.Push((char)i);
                Console.WriteLine($"{charStack.Peek()} yığına eklendi");
                Console.WriteLine($"Char Count: {charStack.Count}");
            }
            Console.WriteLine(new string('-',40));

            var arrayStack = charStack.ToList();
            foreach (var item in arrayStack)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine(new string('-', 40));



            while (charStack.Count> 0)
            {
                Console.WriteLine($"Pop this char {charStack.Peek()}");
                charStack.Pop();
                Console.WriteLine($"Char Count: {charStack.Count}");
            }

            Console.ReadLine();
        }
    }
}
