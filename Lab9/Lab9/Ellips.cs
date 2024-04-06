using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Ellips:Figure
    {
        public int R1 { set; get; }
        public int R2 { set; get; }
        public Ellips(int r,int r1,int r2):base(r)
        {
            R1 = r1;
            R2 = r2;
        }
        public override void Print()
        {
            Console.WriteLine($"Радиус a:{R},Радиус b:{R1},Радиус z:{R2}");
        }
        public override double S()
        {
            return 4 * 3.14 * R * R1;
        }
        public override double V()
        {
            return 4 / 3 * 3.14 * R * R1 * R2;
        }
    }
}
