using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1
{
    class Kings:Country
    {
        public string Rej { set; get; }
        public Kings(string name, int nasel, int s, string rej) : base(name, nasel, s)
        {
            Rej = rej;
        }
        public override void Print()
        {
            Console.WriteLine($"Имя:{Name},Население:{Nasel},Площадь:{S},Режим:{Rej}");
        }
        public override void Sort()
        {
            if (Rej == "Демократия")
            {
                Print();
            }
        }

    }
}
