using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab30
{
    class Diamond
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int CuttingQuality { get; set; }

        public Diamond(string name, double weight, int cuttingQuality)
        {
            Name = name;
            Weight = weight;
            CuttingQuality = cuttingQuality;
        }

        public virtual double CalculateQuality()
        {
            return 0.4 * Weight + 0.6 * CuttingQuality;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}, Вес: {Weight} карат, Качество огранки: {CuttingQuality}, Качество: {CalculateQuality()}");
        }
    }

    class FancyDiamond : Diamond
    {
        public string Color { get; set; }

        public FancyDiamond(string name, double weight, int cuttingQuality, string color) : base(name, weight, cuttingQuality)
        {
            Color = color;
        }

        public override double CalculateQuality()
        {
            double quality = base.CalculateQuality();

            if (Color == "голубой")
            {
                return quality + 1;
            }
            else if (Color == "желтый")
            {
                return quality - 0.5;
            }
            else
            {
                return quality;
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}, Вес: {Weight} карат, Качество огранки: {CuttingQuality}, Цвет: {Color}, Качество: {CalculateQuality()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Diamond diamond = new Diamond("Алмаз1", 3.5, 8);
            diamond.DisplayInfo();

            FancyDiamond fancyDiamond = new FancyDiamond("Алмаз2", 4.2, 9, "голубой");
            fancyDiamond.DisplayInfo();
            Console.ReadKey();
        }
    }
}
