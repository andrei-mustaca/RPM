using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pat = new Pattern();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1-Добавление конуса");
                Console.WriteLine("2-Добавление эллипса");
                Console.WriteLine("3-Выход из добавления элементов");
                switch(Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        pat.Conus();
                        break;
                    case '2':
                        pat.Ellips();
                        break;
                    case '3':flag = false;
                        break;
                    default:Console.WriteLine("Ошибка ввода,попробуйте еще раз");
                        break;
                }
            }
            pat.Vivod();
            pat.Viv1();
            Console.ReadKey();
        }
    }
}
