using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28
{
    class Triangle
    {
        public double Alpha { get; set; }
        public double Beta { get; set; }
        public double Gamma { get; set; }

        public Triangle(double alpha, double beta, double gamma)
        {
            Alpha = alpha;
            Beta = beta;
            Gamma = gamma;
        }

        public void ProcessData()
        {
            Console.WriteLine("Обработка данных в классе Triangle...");
            // Реализация обработки данных
        }
    }

    class RightTriangle : Triangle
    {
        public double BetaRadians { get; set; }

        public RightTriangle(double alpha, double beta, double gamma, double betaRadians) : base(alpha, beta, gamma)
        {
            BetaRadians = betaRadians;
        }

        public double CalculateAngleDifference()
        {
            double angleDifference = Math.Abs(BetaRadians - Alpha);
            return angleDifference;
        }

        public new void ProcessData()
        {
            Console.WriteLine("Обработка данных в классе RightTriangle...");
            // Реализация обработки данных
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования классов
            Triangle triangle = new Triangle(30, 60, 90);
            triangle.ProcessData();

            RightTriangle rightTriangle = new RightTriangle(30, 90, 60, Math.PI / 2);
            Console.WriteLine($"Разность между заданным углом b и углом a : {rightTriangle.CalculateAngleDifference()}");
            rightTriangle.ProcessData();
            Console.ReadKey();
        }
    }
}
