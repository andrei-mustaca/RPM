using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle<T>
    {
        private T a;
        public T A { set; get; }
        private T b;
        public T B { set; get; }
        private T c;
        public T C { set; get; }
        public Triangle(T a,T b,T c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void Print()
        {
            Console.WriteLine($"a={A},b={B},c={C}");
        }
        public double S()
        {
            dynamic x = A;
            dynamic y = B;
            dynamic z = C;
            dynamic p = (x+y+z) / 3;
            return Math.Sqrt(p * (p - x)*(p - y)*(p - z));
        }
    }
}
