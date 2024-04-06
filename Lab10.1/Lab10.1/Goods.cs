using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab10._1
{
    abstract class Goods
    {
        public string Name { set; get; }
        public int Cost { set; get; }
        public Goods() { }
        public Goods(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
        public abstract void Print();
        public abstract void Sort();

    }
}