using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab24
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1Path = @"C:\Users\andre\OneDrive\Документы\GitHub\RPM\Lab24\Матрица1";
            string file2Path = @"C:\Users\andre\OneDrive\Документы\GitHub\RPM\Lab24\Матрица2";
            string file3Path = @"C:\Users\andre\OneDrive\Документы\GitHub\RPM\Lab24\Матрица3";

            // Параметры для генерации случайных матриц
            int m = 3; // количество строк в матрице
            int n = 3; // количество столбцов в матрице
            int k = 5; // количество матриц в первом файле
            int l = 4; // количество матриц во втором файле

            // Генерация и запись случайных матриц в файлы
            GenerateRandomMatricesToFile(file1Path, k, m, n);
            GenerateRandomMatricesToFile(file2Path, l, m, n);

            // Чтение матриц из файлов
            List<int[,]> matrices1 = ReadMatricesFromFile(file1Path);
            List<int[,]> matrices2 = ReadMatricesFromFile(file2Path);

            // Обмен матрицами
            int minLength = Math.Min((matrices1.Count + 1) / 2, matrices2.Count / 2);

            for (int i = 0; i < minLength; i++)
            {
                int oddIndex1 = 2 * i + 1;
                int evenIndex2 = 2 * i;

                var temp = matrices1[oddIndex1];
                matrices1[oddIndex1] = matrices2[evenIndex2];
                matrices2[evenIndex2] = temp;
            }

            // Запись обновленных матриц обратно в файлы
            WriteMatricesToFile(file1Path, matrices1);
            WriteMatricesToFile(file2Path, matrices2);

            // Переписывание оставшихся матриц в третий файл
            using (StreamWriter writer = new StreamWriter(file3Path))
            {
                if (matrices1.Count > matrices2.Count)
                {
                    for (int i = matrices2.Count; i < matrices1.Count; i++)
                    {
                        WriteMatrix(writer, matrices1[i]);
                    }
                }
                else
                {
                    for (int i = matrices1.Count; i < matrices2.Count; i++)
                    {
                        WriteMatrix(writer, matrices2[i]);
                    }
                }
            }

            // Вывод содержимого файлов на экран
            Console.WriteLine("File 1 content:");
            PrintFileContent(file1Path);

            Console.WriteLine("File 2 content:");
            PrintFileContent(file2Path);
            Console.ReadKey();
        }

        static void GenerateRandomMatricesToFile(string filePath, int matrixCount, int rows, int cols)
        {
            Random rand = new Random();
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int k = 0; k < matrixCount; k++)
                {
                    int[,] matrix = new int[rows, cols];
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[i, j] = rand.Next(1, 101); // случайные числа от 1 до 100
                            writer.Write(matrix[i, j] + " ");
                        }
                        writer.WriteLine();
                    }
                    writer.WriteLine();
                }
            }
        }

        static List<int[,]> ReadMatricesFromFile(string filePath)
        {
            List<int[,]> matrices = new List<int[,]>();
            string[] lines = File.ReadAllLines(filePath);
            List<int[]> currentMatrix = new List<int[]>();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (currentMatrix.Count > 0)
                    {
                        matrices.Add(ConvertListToMatrix(currentMatrix));
                        currentMatrix.Clear();
                    }
                }
                else
                {
                    var elements = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (elements.Length > 0)
                    {
                        try
                        {
                            currentMatrix.Add(Array.ConvertAll(elements, int.Parse));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"Ошибка форматирования строки: {line}");
                        }
                    }
                }
            }

            if (currentMatrix.Count > 0)
            {
                matrices.Add(ConvertListToMatrix(currentMatrix));
            }

            return matrices;
        }

        static int[,] ConvertListToMatrix(List<int[]> list)
        {
            int rows = list.Count;
            int cols = list[0].Length;
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = list[i][j];
                }
            }
            return matrix;
        }

        static void WriteMatricesToFile(string filePath, List<int[,]> matrices)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var matrix in matrices)
                {
                    WriteMatrix(writer, matrix);
                }
            }
        }

        static void WriteMatrix(StreamWriter writer, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    writer.Write(matrix[i, j] + " ");
                }
                writer.WriteLine();
            }
            writer.WriteLine();
        }

        static void PrintFileContent(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
