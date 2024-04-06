using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Toys:Goods
    {
        public Toys(string name,int cost):base(name,cost)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"Имя:{Name},Cost:{Cost}");
        }
        public override void Sort()
        {
            if(Cost>5000)
            {
                Print();
            }
        }
    }
}
