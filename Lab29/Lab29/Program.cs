using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29
{
    class ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public virtual void ProcessData()
        {
            Console.WriteLine("Обработка данных в классе ComplexNumber...");
            // Реализация обработки данных
        }

        public override string ToString()
        {
            return $"Действительная часть: {RealPart}, Мнимая часть: {ImaginaryPart}";
        }
    }

    class ComplexResistance : ComplexNumber
    {
        public double Resistance { get; set; }
        public double Inductance { get; set; }

        public ComplexResistance(double realPart, double imaginaryPart, double resistance, double inductance) : base(realPart, imaginaryPart)
        {
            Resistance = resistance;
            Inductance = inductance;
        }

        public override void ProcessData()
        {
            Console.WriteLine("Обработка данных в классе ComplexResistance...");
            // Реализация обработки данных
        }

        public override string ToString()
        {
            return $"Действительная часть: {RealPart}, Мнимая часть: {ImaginaryPart}, Сопротивление: {Resistance}, Индуктивность: {Inductance}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования классов
            ComplexNumber complexNumber = new ComplexNumber(3, 4);
            complexNumber.ProcessData();
            Console.WriteLine(complexNumber);

            ComplexResistance complexResistance = new ComplexResistance(2, 5, 10, 20);
            complexResistance.ProcessData();
            Console.WriteLine(complexResistance);
            Console.ReadKey();
        }
    }
}
