using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int cols = 3;
            int[,] matrix = GenerateRandomMatrix(rows, cols);

            Console.WriteLine("Сгенерированная матрица:");
            PrintMatrix(matrix);

            Task<int> maxTask = Task.Run(() => FindMaxElement(matrix));

            maxTask.ContinueWith((task) =>
            {
                int maxElement = task.Result;
                Console.WriteLine("Максимальный элемент в матрице: " + maxElement);
            });

            Console.ReadLine(); // Для того чтобы консольное приложение не завершилось сразу
        }

        static int[,] GenerateRandomMatrix(int rows, int cols)
        {
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 101); // Генерируем случайное число от 1 до 100
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int FindMaxElement(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxElement = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                    }
                }
            }

            return maxElement;
        }
    }
    
}
