using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 5, 10, 15, 20, 30, 30, 1000, 40, 45, 50 }; // Пример данных
            int maxValue = 30; // Максимальное возможное значение

            try
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] > maxValue)
                    {
                        int replacement = GetReplacement(data, i, maxValue);
                        data[i] = replacement;
                    }
                }

                Console.WriteLine("Обработанные данные:");
                foreach (int item in data)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }

        static int GetReplacement(int[] data, int index, int maxValue)
        {
            int sum = 0;
            int count = 0;
            int i = index + 1;

            // Суммируем следующие 3 числа или все доступные числа, если их меньше
            while (i < data.Length && count < 3)
            {
                sum += data[i];
                count++;
                i++;
            }

            // Если сумма средних 3 чисел все еще больше максимального значения,
            // то берем среднее следующих 10 чисел или всех доступных чисел, если их меньше
            if (count > 0 && sum / count > maxValue)
            {
                sum = 0;
                count = 0;
                i = index + 1;

                while (i < data.Length && count < 10)
                {
                    sum += data[i];
                    count++;
                    i++;
                }
            }

            // Если среднее следующих 10 чисел все еще больше максимального значения,
            // то берем среднее по всей выборке
            if (count > 0 && sum / count > maxValue)
            {
                sum = 0;
                count = 0;

                foreach (int num in data)
                {
                    sum += num;
                    count++;
                }
            }

            // Если и после этого число слишком велико, генерируем исключение
            if (count > 0 && sum / count > maxValue)
            {
                throw new Exception("Невозможно обработать данные: число слишком велико.");
            }

            // Возвращаем среднее значение
            return count > 0 ? sum / count : 0;
        }
    }
}
