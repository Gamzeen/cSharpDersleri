using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Student
    {
        private int _studentNo;
        private string _studentFName;
        private string _studentLName;
        private int _exam1;
        private int _exam2;
        private int _examFinal;
        private string _schoolName;

        public Student(int studentNo, string studentFName, string studentLName, int exam1, int exam2, int examFinal, string schoolName)
        {
            _studentNo = studentNo;
            _studentFName = studentFName;
            _studentLName = studentLName;
            _exam1 = exam1;
            _exam2 = exam2;
            _examFinal = examFinal;
            _schoolName = schoolName;
        }

        public void StudentInformation()
        {
            Console.WriteLine("Öğrenci Numarası: " + _studentNo);
            Console.WriteLine("Öğrenci İsmi: " + _studentFName);
            Console.WriteLine("Öğrenci Soyismi: " + _studentLName);
            Console.WriteLine("Öğrenci Vize 1: " + _exam1);
            Console.WriteLine("Öğrenci Vize 2: " + _exam2);
            Console.WriteLine("Öğrenci Final: " + _examFinal);
            Console.WriteLine("Öğrenci Okulunun adı: " + _schoolName);
        }

        public double StudentExamAverage()
        {
            double average = (_exam1 + _exam2 + _examFinal) / 3;
            return average;
        }

        public void StudentSchool()
        {
            Console.WriteLine("Öğrenci Okulunun adı: " + _schoolName);
        }

    }
}
