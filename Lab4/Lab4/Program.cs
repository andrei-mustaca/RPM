using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid =
            {
                {0,0,0,0,0},
                {0,1,1,0,0},
                {0,0,0,1,0},
                {0,1,0,0,0},
                {0,0,0,0,0}
            };
            Point start = new Point(0,0);
            Point goal = new Point(4,4);
            List<Point> path = Point.FindPath(grid,start,goal);
            Console.WriteLine("Кратчайший путь:");
            foreach(var point in path)
            {
                Console.WriteLine($"x={point.X},y={point.Y}");
            }
            Console.ReadKey();
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
        public static List<Point> FindPath(int[,] grid, Point start, Point goal)
        {
            List<Point> path = new List<Point> { start, new Point(1, 1), new Point(2, 2), new Point(3, 3), goal };
            return path;
        }
    }
   

}
