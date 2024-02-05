using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            for (int i=0; i<A.Length;i++)
            {
                Console.Write("Введите элемент массива по формуле:");
                int b = Convert.ToInt32(Console.ReadLine());
                A[i] = Convert.ToInt32(Math.Pow(b,b));
            }
            for(int i=0;i<A.Length;i++)
            {
                int j = i;
                while(j>0&&A[j]<A[j-1])
                {
                    int temp = A[j];
                    A[j] = A[j - 1];
                    A[j - 1] = temp;
                    j = j - 1;
                }
            }
            foreach(int elem in A)
            {
                Console.WriteLine($"mass={elem}");
            }
            Console.ReadKey();
        }
    }
}
