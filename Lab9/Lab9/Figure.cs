using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    abstract class Figure
    {
        public int R { set; get; }
        public Figure(int r)
        {
            R = r;
        }
        public abstract void Print();
        public abstract double S();
        public abstract double V();
    }
}
