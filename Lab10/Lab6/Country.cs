using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    abstract class Country
    {
        public string Name { set; get; }
        public int Nasel { set; get; }
        public int S { set; get; }
        public Country(string name,int nasel,int s)
        {
            Name = name;
            Nasel = nasel;
            S = s;
        }
        public abstract void Print();
        public abstract void Sort();
    }
}
