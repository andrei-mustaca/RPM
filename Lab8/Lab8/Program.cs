using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Goods> list = new List<Goods>();
                Console.Write("Размерность коллекции:");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите имя:");
                    string name = Console.ReadLine();
                    Console.Write("Введите артикул:");
                    int artic = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите цену:");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите дату производства:");
                    DateTime date1 = DateTime.Parse(Console.ReadLine());
                    Console.Write("Введите дату реализации:");
                    DateTime date2 = DateTime.Parse(Console.ReadLine());
                    list.Add(new Goods(name, artic, price, date1, date2));
                }
                Console.WriteLine("Полная информация о товарах:");
                foreach (var elem in list)
                {
                    elem.Print();
                }
                Console.Write("Введите потолок стоимости:");
                int maxcost = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите название товара:");
                string namen = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    if (list[i].Name == namen)
                    {
                        if (list[i].Price >= maxcost)
                        {
                            Console.WriteLine($"Стоимость этого товара {list[i].Name} с учетом скидки:{list[i].AntiCost()} руб");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Введено неправильное значение");
            }
           
            Console.ReadLine();
        }
    }
}
