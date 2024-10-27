using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Console.Write("Введите первую дату:");
            //DateTime date1 = DateTime.Parse(Console.ReadLine());
            //Console.Write("Введите вторую дату:");
            //DateTime date2 = DateTime.Parse(Console.ReadLine());
            //TimeSpan time = date2 - date1;
            //Console.WriteLine($"Разница в секундах:{time.TotalSeconds}");

            //Задача 2
            //string direction = "Одесса-Киев"; // Направление поезда
            //string departureTime = "18:30"; // Время отправления (24-часовой формат)
            //int platformNumber = 1; // Номер платформы
            //int trackNumber = 2; // Номер пути

            //// Преобразование времени отправления в DateTime
            //DateTime departureDateTime = DateTime.Parse(departureTime);

            //// Текущее системное время
            //DateTime currentTime = DateTime.Now;

            //// Расчет количества минут до отправления
            //int minutesUntilDeparture = (int)(departureDateTime - currentTime).TotalMinutes;

            //// Формирование текста бегущей строки
            //string runningLineText = $"Поезд следованием {direction} отправляется от {platformNumber} платформы {trackNumber} пути через {minutesUntilDeparture} мин";

            //// Вывод текста бегущей строки
            //Console.WriteLine(runningLineText);
            Console.ReadKey();
        }
    }
}
