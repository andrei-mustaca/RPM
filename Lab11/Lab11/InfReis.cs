using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class InfReis
    {
        public string Reis { set; get; }
        public int Ek_m { set; get; }
        public int Biz_m { set; get; }
        public InfReis(string reis,int ek_m,int biz_m)
        {
            Reis = reis;
            Ek_m = ek_m;
            Biz_m = biz_m;
        }
        public void Print()
        {
            Console.WriteLine($"Рейс:{Reis},Места эконома:{Ek_m},Места бизнес-класса:{Biz_m}");
        }
    }
}
