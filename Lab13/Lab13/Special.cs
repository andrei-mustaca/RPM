using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public delegate void Message(Special special);
    public delegate List<Special> Message1(List<Special> specials);
    public class Special
    {
        public string Name { set; get; }
        public int Number { set; get; }
        public int K { set; get; }
        public int B { set; get; }
        public Special(string name,int number,int k,int b)
        {
            Name = name;
            Number = number;
            K = k;
            B = b;
        }
        public static void Print(Special special)
        {
            Console.WriteLine($"Название:{special.Name},Номер:{special.Number},Кол-во контрактных мест:{special.K},Кол-во бюджетных мест:{special.B}");
        }
        public static List<Special> Sort(List<Special>specials)
        {
            specials.Sort((x,y)=>x.Number.CompareTo(y.Number));
            return specials;
        }
        public static List<Special> Sort1(List<Special> specials)
        {
            specials.Sort((x, y) => x.K.CompareTo(y.K));
            return specials;
        }
        public static List<Special> Sort2(List<Special> specials)
        {
            specials.Sort((x, y) => x.B.CompareTo(y.B));
            return specials;
        }
        public static Special Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите номер:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во котркатных мест:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во бюджетных мест:");
            int b = Convert.ToInt32(Console.ReadLine());
            return new Special(name,number,k,b);
        }
    }
}
