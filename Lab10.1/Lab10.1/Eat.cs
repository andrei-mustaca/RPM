using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1
{
    class Eat:Goods
    {
        public DateTime Date1 { set; get; }
        public DateTime Date2 { set; get; }
        public Eat(string name, int cost, DateTime date1, DateTime date2) : base(name, cost)
        {
            Date1 = date1;
            Date2 = date2;
        }
        public override void Print()
        {
            Console.WriteLine($"Имя:{Name},Стоимость:{Cost},Дата производства:{Date1.ToShortDateString()},Дата истекающего срока годности:{Date2.ToShortDateString()}");
        }
        public override void Sort()
        {
            if (Date2 < DateTime.Now)
            {
                Print();
            }
        }

    }
}
