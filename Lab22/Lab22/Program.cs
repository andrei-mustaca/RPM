using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //for(int i=0;i<5;i++)
            //{
            //    Zad1();
            //}
            //using (StreamReader reader = new StreamReader(@"C:\Users\andre\OneDrive\Документы\GitHub\RPM\Lab22\Автомобиль"))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Zad1Read(line);
            //    }
            //}

            //Задание 2
            //for (int i = 0; i < 1; i++)
            //{
            //    Zad2();
            //}
            using (StreamReader reader = new StreamReader(@"C:\Users\andre\OneDrive\Документы\GitHub\RPM\Lab22\Числа"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Zad2Read(line);
                }
            }
            Console.ReadKey();
        }
        public static void Zad1()
        {
            Console.Write("Введите марку:");
            string marka = Console.ReadLine();
            Console.Write("Введите цвет:");
            string color = Console.ReadLine();
            Console.Write("Введите серийный номер:");
            int ser = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год выпуска:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите год выпуска:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену:");
            int price = int.Parse(Console.ReadLine());
            using (StreamWriter writer=new StreamWriter(@"C:\Users\andre\OneDrive\Документы\GitHub\RPM\Lab22\Автомобиль",true))
            {
                writer.WriteLine($"{marka};{color};{ser};{date.ToShortDateString()};{year};{price}");
            }
        }
        public static void Zad1Read(string line)
        {
            string[] parts = line.Split(';');
            if(DateTime.Now.Year-Convert.ToDateTime(parts[3]).Year>2)
            {
                Console.WriteLine(line);
            }
        }
        public static void Zad2()
        {
            Console.Write("Введите первую цифру:");
            string one =Console.ReadLine();
            Console.Write("Введите вторую цифру:");
            string two =Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(@"C:\Users\andre\OneDrive\Документы\GitHub\RPM\Lab22\Числа", true))
            {
                writer.WriteLine($"{one};{two}");
            }
        }
        public static void Zad2Read(string line)
        {
            try
            {
                string[] parts = line.Split(';');
                int rez = Convert.ToInt32(parts[0]) + Convert.ToInt32(parts[1]);
                Console.WriteLine($"Результат сложения:{rez}");
            }
            catch
            {
                Console.WriteLine("Входная строка имела неверный формат");
            }
        }
    }
}
