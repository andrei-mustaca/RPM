using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._1
{
    using System;

    delegate float Delegate(Func<Action<bool>, float, float> func, float x);

    class Program
    {
        static void Main(string[] args)
        {
            Delegate delegate1 = Method;
            Console.WriteLine("Уравнение,которое необходимо решить:x^2+2*x-1=34");
            Console.Write("Введите x:");
            float x = Convert.ToSingle(Console.ReadLine());
            float result = delegate1(Function, x);
            Console.WriteLine($"Result={result}");

            Console.ReadKey();
        }

        static float Method(Func<Action<bool>, float, float> func, float x)
        {
            return func(Console.WriteLine, x*x+2*x-1);
        }
        static float Function(Action<bool> action, float x)
        {
           if(x==34)
           {
                action(true);
                Console.WriteLine("X найден");
           }
           else
           {
                action(false);
                Console.WriteLine("X не найден");
            }
            return x;
        }
    }

}
