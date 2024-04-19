using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Tur_firm:IComparable<Tur_firm>
    {
        private string name;
        public string Name { set; get; }
        private int date;
        public int Date { set; get; }
        private int inn;
        public int Inn { set; get; }
        private int price;
        public int Price { set; get; }
        public Tur_firm() { }
        public Tur_firm(string name,int date,int inn,int price)
        {
            Name = name;
            Date = date;
            Inn = inn;
            Price = price;
        }
        public void Print()
        {
            Console.WriteLine($"Имя:{Name}\nДата основания:{Date}\nИНН:{Inn}\nПрибыль за текущий год:{Price}");
        }
        public int CompareTo(Tur_firm obj)
        {
            return Price.CompareTo(obj.Price);
        }
        //public void Poisk(string name)
        //{
        //    if(name==Name)
        //    {
        //        Console.WriteLine($"ИНН:{Inn}\nДоход:{Price}");
        //    }
        //}
        //public int Cost(List<Tur_firm>list)
        //{
        //    int sum = 0;
        //    for(int i=0;i<list.Count;i++)
        //    {
        //        sum += list[i].Price;
        //    }
        //    return sum;
        //}
        //public void 
    }
}
