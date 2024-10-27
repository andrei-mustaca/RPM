using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27
{
    class EmailMessage
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime SentDateTime { get; set; }
        public double SizeKb { get; set; }

        public int DaysSinceSent()
        {
            return (DateTime.Now - SentDateTime).Days;
        }

        public override string ToString()
        {
            return $"Отправитель: {Sender}, Получатель: {Receiver}, Дата отправки: {SentDateTime.ToShortDateString()}, " +
                   $"Время отправки: {SentDateTime.ToShortTimeString()}, Размер сообщения: {SizeKb} Кб, " +
                   $"Срок давности: {DaysSinceSent()} дней";
        }
    }

    class Program
    {
        static void Main()
        {
            List<EmailMessage> emailMessages = new List<EmailMessage>
        {
            new EmailMessage { Sender = "sender1@example.com", Receiver = "receiver1@example.com", SentDateTime = new DateTime(2024, 5, 1, 10, 30, 0), SizeKb = 50.5 },
            new EmailMessage { Sender = "sender2@example.com", Receiver = "receiver2@example.com", SentDateTime = new DateTime(2024, 5, 2, 14, 45, 0), SizeKb = 75.0 },
            new EmailMessage { Sender = "sender3@example.com", Receiver = "receiver3@example.com", SentDateTime = new DateTime(2024, 5, 3, 9, 0, 0), SizeKb = 20.0 }
        };

            // Подсчет количества сообщений и общего объема в прошлом месяце
            DateTime lastMonth = DateTime.Now.AddMonths(-1);
            int messagesCountLastMonth = emailMessages.Count(email => email.SentDateTime.Month == lastMonth.Month && email.SentDateTime.Year == lastMonth.Year);
            double totalSizeLastMonthMb = emailMessages.Where(email => email.SentDateTime.Month == lastMonth.Month && email.SentDateTime.Year == lastMonth.Year).Sum(email => email.SizeKb) / 1024;
            Console.WriteLine($"Количество сообщений, отправленных в прошлом месяце: {messagesCountLastMonth}");
            Console.WriteLine($"Общий объем сообщений в прошлом месяце: {totalSizeLastMonthMb:F2} Мб");

            // Вывод информации о первом сообщении, отправленном в домен net для введенной даты
            Console.WriteLine("Введите дату (гггг-мм-дд):");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());
            var firstNetMessage = emailMessages.FirstOrDefault(email => email.SentDateTime.Date == inputDate.Date && email.Receiver.EndsWith("@net"));
            if (firstNetMessage != null)
            {
                Console.WriteLine($"Первое сообщение, отправленное в домен net для {inputDate.ToShortDateString()}:");
                Console.WriteLine(firstNetMessage);
            }
            else
            {
                Console.WriteLine($"Сообщений в домен net для {inputDate.ToShortDateString()} не найдено.");
            }

            // Упорядочивание информации по дате отправки сообщений и вывод в консоль
            var orderedMessages = emailMessages.OrderBy(email => email.SentDateTime);
            foreach (var email in orderedMessages)
            {
                Console.WriteLine(email);
            }
            Console.ReadKey();
        }
    }
}
