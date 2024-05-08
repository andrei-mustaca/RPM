using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPoolManager manager = new ThreadPoolManager();

            // Добавляем элементы в коллекцию
            manager.AddElements(100);

            // Запускаем обработку элементов с использованием пула потоков
            manager.ProcessElements();

            Console.WriteLine($"Главный поток завершен.Результат:{ThreadPoolManager.Sum}");
            Console.ReadKey();
        }
    }
    class Element
    {
        public int Value { get; set; }

        // Метод, который выполняется при обработке элемента
        public void Process()
        {
            // Задержка алгоритма для наглядности
            Thread.Sleep(100); // Измените значение для искусственной задержки
            Console.WriteLine($"Элемент {Value} обработан в потоке {Thread.CurrentThread.ManagedThreadId}");
        }
    }
    class ThreadPoolManager
    {
        private List<Element> elements = new List<Element>();
        public static int Sum { set; get; }

        // Добавление элементов в коллекцию
        public void AddElements(int count)
        {
            Sum = 0;
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                elements.Add(new Element { Value = rand.Next(1, 101) });
                if(elements[i].Value%3==0)
                {

                }
                else
                {
                    elements[i].Value = 0;
                }
                Sum += elements[i].Value;
            }
        }

        // Обработка элементов с использованием пула потоков
        public void ProcessElements()
        {
            Parallel.ForEach(elements, element =>
            {
                element.Process();
            });
        }
    }
}
