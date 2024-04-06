using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Student
    {
        public string Name { set; get; }
        public string Surname { set; get; }
        public int Kurs { set; get; }
        public int Year { set; get; }

        public Student() { }
        public Student(string name,string surname,int kurs,int year)
        {
            Name = name;
            Surname = surname;
            Kurs = kurs;
            Year = year;
        }
        public void Print()
        {
            Console.WriteLine($"Имя:{Name},Фамилия:{Surname},Курс:{Kurs},Возраст:{Year}");
        }

        public void One_kurs()
        {
            if(Kurs==1)
            {
                Print();
            }
        }
    }
}
