using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса круга");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение координаты x точки");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение координаты y точки");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение координаты x0 центра окружности");
            double x0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение координаты y0 центра окружности");
            double y0 = Convert.ToDouble(Console.ReadLine());

            double length = Circle.GetLength(r);
            double square = Circle.GetSquare(r);
            
            
            
            double affiliation = Circle.GetAffiliation(x, y, x0, y0);


            Console.WriteLine();
            Console.WriteLine("Длина окружности равна " + length);
            Console.WriteLine("Площадь окружности равна " + square);
            Console.WriteLine(affiliation);
            Console.WriteLine((Math.Pow(r, 2)) == affiliation ? "Точка принадлежит окружности" : "Точка НЕ принадлежит окружности");
            Console.ReadLine();

        }
    }
}
