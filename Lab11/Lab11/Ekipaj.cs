using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Ekipaj
    {
        public int Kol_vo_ek { set; get; }
        public string Av1 { set; get; }
        public string Av2 { set; get; }
        public Ekipaj(int kol_vo_ek,string av1,string av2)
        {
            Kol_vo_ek = kol_vo_ek;
            Av1 = av1;
            Av2 = av2;
        }
        public void Print()
        {
            Console.WriteLine($"Кол-во экипажа:{Kol_vo_ek},Первый пилот:{Av1},Второй пилот:{Av2}");
        }
    }
}
