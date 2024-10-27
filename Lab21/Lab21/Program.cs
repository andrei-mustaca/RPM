using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Task<int[]> generateArrayTask = Task.Run(() => GenerateRandomArray());

          
            generateArrayTask.ContinueWith((task) =>
            {
                int[] randomArray = task.Result;
                Console.WriteLine("Сгенерированный массив случайных чисел:");
                PrintArray(randomArray);

                
                Task<int> findMaxTask = Task.Run(() => FindMaxElement(randomArray));

             
                findMaxTask.ContinueWith((maxTask) =>
                {
                    int maxElement = maxTask.Result;
                    Console.WriteLine("Максимальный элемент в массиве: " + maxElement);
                });
            });

            Console.ReadLine();
        }

        static int[] GenerateRandomArray()
        {
            Random rand = new Random();
            int size = rand.Next(5, 11);  
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, 101);
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static int FindMaxElement(int[] array)
        {
            int maxElement = array[0];
            foreach (var element in array)
            {
                if (element > maxElement)
                {
                    maxElement = element;
                }
            }
            return maxElement;
        }
    }
}
