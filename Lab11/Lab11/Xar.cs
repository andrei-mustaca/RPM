using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Xar
    {
        public int Mass { set; get; }
        public int V { set; get; }
        public Xar(int mass,int v)
        {
            Mass = mass;
            V = v;
        }
        public void Print()
        {
            Console.WriteLine($"Масса:{Mass},Скорость:{V}");
        }
    }
}
