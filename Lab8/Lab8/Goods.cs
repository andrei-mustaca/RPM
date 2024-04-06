using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Goods
    {
        public string Name { set; get; }
        public int Artic { set; get; }
        public int Price { set; get; }
        public DateTime Date1 { set; get; }
        public DateTime Date2 { set; get; }
        public Goods(){}
        public Goods(string name,int artic,int price,DateTime date1,DateTime date2)
        {
            Name = name;
            Artic = artic;
            Price = price;
            Date1 = date1;
            Date2 = date2;
        }
        public double AntiCost()
        {
            Console.Write("Введите процент:");
            int proc = Convert.ToInt32(Console.ReadLine());
            return Price - (Price / 100 * proc);
        }
        public void Print()
        {
            Console.WriteLine($"Имя:{Name},Артикул:{Artic},Дата производства:{Date1.ToShortDateString()},Дата реализации:{Date2.ToShortDateString()},Цена:{Price}");
        }
    }
}
