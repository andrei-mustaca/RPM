using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26
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
            new EmailMessage { Sender = "sender1@example.com", Receiver = "receiver1@example.com", SentDateTime = new DateTime(2024, 6, 1, 10, 30, 0), SizeKb = 50.5 },
            new EmailMessage { Sender = "sender2@example.com", Receiver = "receiver2@example.com", SentDateTime = new DateTime(2024, 6, 2, 14, 45, 0), SizeKb = 75.0 },
            new EmailMessage { Sender = "sender3@example.com", Receiver = "receiver3@example.com", SentDateTime = new DateTime(2024, 6, 3, 9, 0, 0), SizeKb = 20.0 }
        };

            Console.WriteLine("Сведения обо всех отправленных сообщениях:");
            foreach (var email in emailMessages)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("\nВведите дату (гггг-мм-дд):");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите начало интервала времени (чч:мм):");
            TimeSpan startTime = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец интервала времени (чч:мм):");
            TimeSpan endTime = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine($"\nОтправители, пославшие сообщения {inputDate.ToShortDateString()} с {startTime} до {endTime}:");

            var filteredEmails = emailMessages.Where(email =>
                email.SentDateTime.Date == inputDate.Date &&
                email.SentDateTime.TimeOfDay >= startTime &&
                email.SentDateTime.TimeOfDay <= endTime);

            foreach (var email in filteredEmails)
            {
                Console.WriteLine($"Отправитель: {email.Sender}");
            }
            Console.ReadKey();
        }
        
    }
}
