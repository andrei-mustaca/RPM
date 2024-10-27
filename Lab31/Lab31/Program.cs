using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab31
{
    class Triangle
    {
        public double a, b, c;

        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;
        }

        public virtual double Perimeter()
        {
            return a + b + c;
        }

        public virtual double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public virtual string Information()
        {
            return $"Треугольник со сторонами a = {a}, b = {b}, c = {c}. Периметр: {Perimeter()}. Площадь: {Area()}";
        }
    }

    class Quadrilateral : Triangle
    {
        private double d, e, f;

        public Quadrilateral(double sideA, double sideB, double sideC, double sideD, double diagonalE, double diagonalF) : base(sideA, sideB, sideC)
        {
            d = sideD;
            e = diagonalE;
            f = diagonalF;
        }

        public override double Perimeter()
        {
            return base.Perimeter() + d;
        }

        public override double Area()
        {
            return a*d;
        }

        public override string Information()
        {
            return $"Четырехугольник со сторонами a = {a}, b = {b}, c = {c}, d = {d}, диагоналями e = {e}, f = {f}. Периметр: {Perimeter()}. Площадь: {Area()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.Information());

            Quadrilateral square = new Quadrilateral(4, 4, 4, 4, 4 * Math.Sqrt(2), 4 * Math.Sqrt(2)); // квадрат
            Console.WriteLine(square.Information());
            Console.ReadKey();
        }
    }
}
