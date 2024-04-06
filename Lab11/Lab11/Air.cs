using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Air
    {
        public Xar x;
        public Ekipaj ek;
        public InfReis rei;
       
        public Air(int mass,int v,int kol_vo,string av1,string av2,string reis,int ek_m,int biz_m)
        {
            this.x = new Xar(mass,v);
            this.ek = new Ekipaj(kol_vo,av1,av2);
            this.rei = new InfReis(reis,ek_m,biz_m);
        }
        public void Print()
        {
            x.Print();
            ek.Print();
            rei.Print();
        }
        public static Air Input()
        {
            Console.Write("Введите массу:");
            int mass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скорость:");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во экипажа:");
            int ek = Convert.ToInt32(Console.ReadLine());
            Console.Write("Первый пилот:");
            string av1 = Console.ReadLine();
            Console.Write("Второй пилот:");
            string av2 = Console.ReadLine();
            Console.Write("Название рейса:");
            string reis = Console.ReadLine();
            Console.Write("Кол-во мест эконома:");
            int ek_m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кол-во мест бизнес-класса:");
            int biz_m = Convert.ToInt32(Console.ReadLine());
            return new Air(mass,v,ek,av1,av2,reis,ek_m,biz_m);
        }
    }
}
