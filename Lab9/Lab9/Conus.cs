using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Conus:Figure
    {
        public int H { set; get; }
        public int L { set; get; }
        public Conus(int r,int h,int l):base(r)
        {
            H = h;
            L = l;
        }
        public override void Print()
        {
            Console.WriteLine($"Радиус:{R},Высота:{H},Образующая:{L}");
        }
        public override double S()
        {
            return 3.14 * R * (R + L);
        }
        public override double V()
        {
            return (3.14 * Math.Pow(R, 2) * H) / 3 ;
        }
    }
}
