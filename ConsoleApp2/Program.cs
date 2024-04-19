using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tur_firm> list = new List<Tur_firm>();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine($"[1]-Добавление фиры\n[2]-Поиск фирмы\n[3]-Суммарная прибыль\n[4]-Поиск фиры с большей стоимость\n[5]-Удаление обанкротившейся фирмы\n[6]-Сортировка\n[7]-Вывод\n[8]-Выход");
                switch(Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        Console.Write("Введите название:");
                        string name = Console.ReadLine();
                        Console.Write("Введите дату основания:");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите ИНН:");
                        int inn = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите прибыль за год:");
                        int price = Convert.ToInt32(Console.ReadLine());
                        list.Add(new Tur_firm(name,year,inn,price));
                        break;
                    case '2':
                        Console.Write("Введите название фирмы:");
                        string name_p = Console.ReadLine();
                        bool not_find = false;
                        for(int i=0;i<list.Count;i++)
                        {
                            if(list[i].Name==name_p)
                            {
                                Console.WriteLine($"ИНН:{list[i].Inn},Прибыль:{list[i].Price}");
                                not_find = true;
                            }
                        }
                        if(not_find==false)
                        {
                            Console.WriteLine("Фирма не найдена");
                        }
                        break;
                    case '3':
                        int sum = 0;
                        for(int i=0;i<list.Count;i++)
                        {
                            sum = sum + list[i].Price;
                        }
                        Console.WriteLine($"Суммарная прибыль равна:{sum}");
                        break;
                    case '4':
                        list.Sort();
                        list[list.Count - 1].Print();
                        break;
                    case '5':
                        for(int i=0;i<list.Count;i++)
                        {
                            if(list[i].Price==0)
                            {
                                list.RemoveAt(i);
                            }
                        }
                        break;
                    case '6':
                        list.Sort();
                        foreach(var elem in list)
                        {
                            elem.Print();
                        }
                        break;
                    case '7':
                        foreach (var elem in list)
                        {
                            elem.Print();
                        }
                        break;
                    case '8':flag = false;
                        break;
                    default:Console.WriteLine("Ошибка");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
