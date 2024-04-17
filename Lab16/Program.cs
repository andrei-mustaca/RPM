using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    internal class Program
    {
        delegate Task<int[]> AsyncRandom(int[]mass,int c);
        delegate int[] Message(int[]mass);
        static async Task Main(string[] args)
        {
            Console.Write("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass1 = new int[n];
            int[] mass2 = new int[n];
            AsyncRandom asyncRandom =AsyncMethod;
            Message message = Input;
            message(mass2);
            Console.Write("Введите время тайм аута:");
            int c = Convert.ToInt32(Console.ReadLine());
            var timeout =TimeSpan.FromSeconds(c);
            if(timeout>TimeSpan.FromSeconds(10))
            {
                Console.WriteLine("Время ожидания истекло");
                return;
            }
            else
            {
                var result = asyncRandom(mass1,c);
            }
            Console.ReadKey();
        }
        static async Task<int[]> AsyncMethod(int[]mass, int c)
        {
            Console.WriteLine("Метод начал выполняться");
            Random random = new Random();
            for(int i=0;i<mass.Length;i++)
            {
                mass[i] = random.Next(20, 50);
                await Task.Delay(c*100);
                Console.WriteLine($"Заполнен элемент:{i}");
                if (mass[i]%2==1)
                {
                    mass[i] = 0;
                }
            }
            foreach (var elem in mass)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("Метод закончил свое выполнение");
            return mass;
        }
        static int[] Input(int[]mass)
        {
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(20, 50);
                Console.WriteLine($"Заполнен элемент:{i}");
                if (mass[i] % 2 == 1)
                {
                    mass[i] = 0;
                }
            }
            foreach (var elem in mass)
            {
                Console.WriteLine(elem);
            }
            return mass;
        }
    }
}
