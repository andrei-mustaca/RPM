using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static int[,] GenerateMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 101); // Генерация случайного числа от 1 до 100
                }
            }

            return matrix;
        }

        static int SumMatrix(int[,] matrix)
        {
            int totalSum = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Parallel.For(0, rows, i =>
            {
                int rowSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    rowSum += matrix[i, j];
                }
                totalSum += rowSum;
            });

            return totalSum;
        }

        static void Main(string[] args)
        {
            int rows = 7; // Замените это значение на желаемое количество строк
            int cols = 5; // Замените это значение на желаемое количество столбцов

            int[,] matrix = GenerateMatrix(rows, cols);

            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int totalSum = SumMatrix(matrix);
            Console.WriteLine("Сумма всех элементов матрицы: " + totalSum);
            Console.ReadKey();
        }
    }
}
