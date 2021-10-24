using System;

namespace StaticCtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Gamzişko", "lovo");
            person.GetInfo();
            person.Income(500);


        }
    }
}
