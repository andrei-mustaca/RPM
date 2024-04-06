using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            bool flag = true;
            while(flag)
            {
                Console.Write("Введите вариант ввода:");
                string vvod = Console.ReadLine();
                switch(vvod)
                {
                    case "Явное объявление":
                        Console.Write("Введите имя:");
                        string name = Console.ReadLine();
                        Console.Write("Введите фамилию:");
                        string surname = Console.ReadLine();
                        Console.Write("Введите курс:");
                        int kurs = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите возраст:");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Student st = new Student();
                        st.Name = name;
                        st.Surname = surname;
                        st.Kurs = kurs;
                        st.Year = year;
                        list.Add(st);
                        break;
                    case "Неявное объявление":
                        Console.Write("Введите имя:");
                        string name1 = Console.ReadLine();
                        Console.Write("Введите фамилию:");
                        string surname1 = Console.ReadLine();
                        Console.Write("Введите курс:");
                        int kurs1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите возраст:");
                        int year1 = Convert.ToInt32(Console.ReadLine());
                        list.Add(new Student(name1,surname1,kurs1,year1));
                        break;
                    case "Выход":flag =false;
                        break;
                    default:Console.WriteLine("Введено неправильное слово");
                        break;
                }
            }
            foreach(var elem in list)
            {
                elem.Print();
            }
            Console.WriteLine("Первокурсники:");
            foreach(var elem in list)
            {
                elem.One_kurs();
            }
            Console.ReadKey();
        }
    }
}
