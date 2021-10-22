using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            Student newStudent = new Student(1, "Gamzişko", "Lovo", 100, 98, 99, "Neü");
            Console.WriteLine("Seçim yapınız...");
           
            while (control)
            {
                Operations();
                string choice=Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        newStudent.StudentInformation();
                        break;
                    case "2":
                        double examAverage = newStudent.StudentExamAverage();
                        Console.WriteLine("Öğrenci Ortalaması" + examAverage);
                        break;
                    case "3":
                        newStudent.StudentSchool();
                        break;
                    case "4":
                        control = false;
                        break;
                }
            }
        }

        static void Operations()
        {
            Console.WriteLine("Öğrenci Bilgileri için 1'i");
            Console.WriteLine("Öğrenci Ortalaması için 2'yi");
            Console.WriteLine("Öğrenci Bilgileri için 3'ü");
            Console.WriteLine("Çıkmak için 4'ü seçiniz.");
        }
    }
}
