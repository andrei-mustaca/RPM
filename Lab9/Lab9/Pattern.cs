using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Pattern
    {
        public List<Figure> list = new List<Figure>();
        public void Conus()
        {
            Console.Write("Введите радиус:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите образующую:");
            int l = Convert.ToInt32(Console.ReadLine());
            list.Add(new Conus(r,h,l));
        }
        public void Ellips()
        {
            Console.Write("Введите радиус a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите радиус b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите радиус z:");
            int z = Convert.ToInt32(Console.ReadLine());
            list.Add(new Ellips(a, b, z));
        }
        public void Vivod()
        {
            foreach(var elem in list)
            {
                elem.Print();
            }
        }
        public void Viv1()
        {
            foreach(var elem in list)
            {
                Console.WriteLine($"Площадь:{elem.S()},Объем:{elem.V()}");
            }
        }
    }
}
