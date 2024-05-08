using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Special> specials = new List<Special>();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("[1] Добавление специальности");
                Console.WriteLine("[2] Выход ");
                switch(Console.ReadKey(true).KeyChar)
                {
                    case '1':specials.Add(Special.Enter());
                        break;
                    case '2':flag = false;
                        break;
                }
            }
            foreach (var elem in specials)
            {
                Message message = new Message(Special.Print);
                message(elem);
            }
            Console.WriteLine("[1] Сортировка по номеру");
            Console.WriteLine("[2] Сортировка по контркатным местам");
            Console.WriteLine("[3] Сортировка по бюджетным местам");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': Message1 message1 = new Message1(Special.Sort);
                    message1(specials);
                    Console.WriteLine("Отсортированные специальности:");
                    foreach (var elem in specials)
                    {
                        Message message = new Message(Special.Print);
                        message(elem);
                    }
                    break;
                case '2':Message1 message2 = new Message1(Special.Sort1);
                    message2(specials);
                    Console.WriteLine("Отсортированные специальности:");
                    foreach (var elem in specials)
                    {
                        Message message = new Message(Special.Print);
                        message(elem);
                    }
                    break;
                case '3':
                    Message1 message3 = new Message1(Special.Sort2);
                    message3(specials);
                    Console.WriteLine("Отсортированные специальности:");
                    foreach (var elem in specials)
                    {
                        Message message = new Message(Special.Print);
                        message(elem);
                    }
                    break;
                default:Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();
        }
    }
}
