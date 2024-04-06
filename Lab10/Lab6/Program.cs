using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Goods> list = new List<Goods>();
            //bool flag = true;
            //while (flag)
            //{
            //    Console.Write("Введите название:");
            //    string n = Console.ReadLine();
            //    switch (n)
            //    {
            //        case "Продукт":
            //            Console.Write("Имя:");
            //            string name = Console.ReadLine();
            //            Console.Write("Стоимость:");
            //            int cost = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("Дата производства:");
            //            DateTime date1 = DateTime.Parse(Console.ReadLine());
            //            Console.Write("Дата истечения срока годности:");
            //            DateTime date2 = DateTime.Parse(Console.ReadLine());
            //            list.Add(new Eat(name, cost, date1, date2));
            //            break;
            //        case "Игрушки":
            //            Console.Write("Имя:");
            //            string name1 = Console.ReadLine();
            //            Console.Write("Стоимость:");
            //            int cost1 = Convert.ToInt32(Console.ReadLine());
            //            list.Add(new Toys(name1, cost1));
            //            break;
            //        default:
            //            flag = false;
            //            break;
            //    }
            //}
            //foreach (var elem in list)
            //{
            //    elem.Print();
            //}
            //Console.WriteLine("Дорогие или просроченные товары:");
            //foreach (var elem in list)
            //{
            //    elem.Sort();
            //}




            List<Country> list = new List<Country>();
            bool flag = true;
            while (flag)
            {
                Console.Write("Введите название:");
                string n = Console.ReadLine();
                switch (n)
                {
                    case "Королевство":
                        Console.Write("Имя:");
                        string name = Console.ReadLine();
                        Console.Write("Население:");
                        int nasel = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Площадь:");
                        int s = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Режим:");
                        string rej = Console.ReadLine();
                        list.Add(new Kings(name, nasel, s, rej));
                        break;
                    case "Государство":
                        Console.Write("Имя:");
                        string name1 = Console.ReadLine();
                        Console.Write("Население:");
                        int nasel1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Площадь:");
                        int s1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Режим:");
                        string rej1 = Console.ReadLine();
                        list.Add(new Respublic(name1, nasel1, s1, rej1));
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            foreach (var elem in list)
            {
                elem.Print();
            }
            Console.WriteLine("Страны с демократическим режимом:");
            foreach (var elem in list)
            {
                elem.Sort();
            }
            Console.ReadKey();
        }
    }
}
