using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public struct Point
    {
        public int X, Y;
        public Point(int x, int y) { this.X = x; this.Y = y; }

        public override string ToString()
        {
            return $"(x{X},y{Y})";
        }
    }

    public class Triangle
    {
        private double perimeter;
        private double side1, side2, side3;
        private Point p1, p2, p3;

        public Triangle(Point a, Point b, Point c)
        {
            p1 = a; p2 = b; p3 = c;
            Sides();
        }

        public void Sides()
        {
            side1 = Math.Pow(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2), 0.5);

            side2 = Math.Pow(Math.Pow(p2.X - p3.X, 2) + Math.Pow(p2.Y - p3.Y, 2), 0.5);

            side3 = Math.Pow(Math.Pow(p3.X - p1.X, 2) + Math.Pow(p3.Y - p1.Y, 2), 0.5);
        }

        public double Perimeter()
        {
            perimeter = Math.Round(side1 + side2 + side3, 2);
            return perimeter;
        }
        public double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            double area = Math.Round(Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3)), 2);
            return area;
        }

    }
    class Program
    {
        /*static void Main(string[] args)
        {
            List<Triangle> triangleList = new List<Triangle>();
            triangleList.Add(new Triangle(new Point(3, 0), new Point(6, 0), new Point(0, 5)));
            triangleList.Add(new Triangle(new Point(1, 2), new Point(7, 2), new Point(3, 3)));

            foreach (Triangle triangle in triangleList)
            {
      
                Console.WriteLine("Perimeter - " + triangle.Perimeter());
                Console.WriteLine("Area - " + triangle.Area());
            }
        }*/
    }
}
