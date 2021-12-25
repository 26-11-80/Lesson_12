using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 8;
            double length = Circle.Length(radius);
            double square = Circle.Square(radius);
            Console.WriteLine("Круг с радиусом {0}, длина окружности = {1}, площадь круга = {2}", radius, length, square);

            double x0 = 2;
            double y0 = 2;
            Console.WriteLine("Круг с радиусом {0} с центром в точке x0 = {1}, y0 = {2}", radius, x0, y0);

            double x1 = 10;
            double y1 = 4;
            Console.Write("Координаты точки x = {0}, y = {1} - ", x1, y1);
            Circle.TochkaVKruge(x1, y1, radius, x0, y0);

            double x2 = 5;
            double y2 = 6;
            Console.Write("Координаты точки x = {0}, y = {1} - ", x2, y2);
            Circle.TochkaVKruge(x2, y2, radius, x0, y0);
            Console.ReadKey();
        }
    }


    public static class Circle
    {
        public static double Length(double radius)
        {
            double length = 2 * Math.PI * radius;
            return length;
        }

        public static double Square(double radius)
        {
            double square = Math.PI * radius * radius;
            return square;
        }

        public static void TochkaVKruge(double x, double y, double radius, double x0, double y0)
        {
            double h = Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0));
            if (h > radius) Console.WriteLine("Точка не принадлежит кругу");
            else Console.WriteLine("Точка принадлежит кругу");
        }
    }
}

        
    

