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
            Console.Write("Введите кол-во элементов:");
            int n = Convert.ToInt32(Console.ReadLine());
            try
            {
                int[] mass = new int[n];
                Console.Write("Введите искомое число:");
                int m = Convert.ToInt32(Console.ReadLine());
                int b = -1;
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write("Ввести элемент массива:");
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i=0;i<n;i++)
                {
                    if(mass[i]==m)
                    {
                        b=i;
                    }
                }
                if(b==-1)
                {
                    Console.WriteLine("Соответствующих элементов в массиве нет");
                }
                else
                {
                    Console.WriteLine($"mass{b}={mass[b]}");
                }
            }
            catch
            {
                Console.WriteLine("Введено неподходящее число");
            }
            Console.ReadKey();
        }
    }
}
