using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator<int> c1 = new Calculator<int>();
            //c1.Add(10, 11);
            //c1.Sub(12,10);
            //c1.Mul(13,12);
            //c1.Div(15,5);
            //Calculator<double> c2 = new Calculator<double>();
            //c2.Add(12.5,13.6);
            //c2.Sub(12.5,13.6);
            //c2.Mul(12.5,13.6);
            //c2.Div(12.5,13.6);
            //Calculator<string> c3 = new Calculator<string>();
            //c3.Add("10","5");
            //c3.Sub("10","5");
            //c3.Mul("10","5");
            //c3.Div("10","5");

            Triangle<int> t1 = new Triangle<int>(10,14,16);
            t1.Print();
            Console.WriteLine($"Площадь:{t1.S()}");
            Triangle<uint> t2 = new Triangle<uint>(10,14,17);
            t2.Print();
            Console.WriteLine($"Площадь:{t2.S()}");
            Triangle<double> t3 = new Triangle<double>(10.5, 14.6, 17.5);
            t3.Print();
            Console.WriteLine($"Площадь:{t3.S()}");
            Console.ReadKey();
        }
    }
}
