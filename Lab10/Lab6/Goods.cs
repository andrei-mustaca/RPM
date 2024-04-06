using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    abstract class Goods
    {
        public string Name { set; get; }
        public int Cost { set; get; }
        public Goods() { }
        public Goods(string name,int cost)
        {
            Name = name;
            Cost = cost;
        }
        public abstract void Print();
        public abstract void Sort();
    }
}
