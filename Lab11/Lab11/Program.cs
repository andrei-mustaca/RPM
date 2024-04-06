using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Air> list = new List<Air>();
                bool flag = true;
                while(flag)
                {
                    Console.WriteLine("1-Добавление");
                    Console.WriteLine("2-Выход");
                    switch(Console.ReadKey(true).KeyChar)
                    {
                        case '1':list.Add(Air.Input());
                            break;
                        case '2':flag = false;
                            break;
                        default:Console.WriteLine("Ошибка ввода");
                            break;
                    }
                }
                bool flag1 = true;
                while (flag1)
                {
                    Console.WriteLine($"1-Вывод\n2-Изменение\n3-Выход из программы");
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '1':
                            foreach (var elem in list)
                            {
                                elem.Print();
                            }
                            break;
                        case '2':
                            Console.Write("Введите элемент коллекции:");
                            int n = Convert.ToInt32(Console.ReadLine());
                            list[n] = Air.Input();
                            break;
                        case '3': return;
                        default:
                            Console.WriteLine("Ошибка ввода");
                            break;
                    }
                }
               
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
    }
}
