using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._2
{
    public delegate float CustomDelegate(Action<bool> action, float value);

    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра делегата и привязка к методам
            CustomDelegate customDelegate = Method1;
            customDelegate += Method2;

            // Вызов делегата с передачей метода действия и значения
            float result = customDelegate(DoAction, 10.5f);
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }

        static float Method1(Action<bool> action, float value)
        {
            Console.WriteLine("Method1 called with value: " + value);
            action(true); // Вызов метода действия
            return value;
        }

        static float Method2(Action<bool> action, float value)
        {
            Console.WriteLine("Method2 called with value: " + value);
            action(true); // Вызов метода действия
            return value / 2;
        }

        static void DoAction(bool success)
        {
            if (success)
                Console.WriteLine("Action succeeded");
            else
                Console.WriteLine("Action failed");
        }
    }

}
