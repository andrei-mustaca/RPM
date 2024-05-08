using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab15
{
    class Program
    {
        public delegate void Message(int[]mass);

        static void Main(string[] args)
        { 
            Console.Write("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            int[] mass1 = new int[n];
            Message delegate1 = new Message(InPut1);
            Task t=InPutAsync(mass);
            t.Wait();
            delegate1(mass1);
            Console.ReadKey();
        }
        public static void InPut(int[]mass)
        {
            Thread.Sleep(10000);
            Random random = new Random();
            for(int i=0;i<mass.Length;i++)
            {
                mass[i] = random.Next(0, 20);
                if (mass[i] % 2 == 1)
                {
                    mass[i] = 0;
                }
            }
            foreach(var elem in mass)
            {
                Console.WriteLine($"elem={elem}");
            }
        }
        public static void InPut1(int[] mass)
        {
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(0, 40);
                if (mass[i] % 2 == 1)
                {
                    mass[i] = 0;
                }
            }
            foreach (var elem in mass)
            {
                Console.WriteLine($"elem={elem}");
            }
        }
        static async Task InPutAsync(int[]mass)
        {
            Console.WriteLine("Метод начал свое выполнение...");
            await Task.Run(()=> InPut(mass));
            Console.WriteLine("Метод выполнен");
        }
    }
}
