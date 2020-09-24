using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2

/*
 * Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). 
 * Найти его периметр и площадь, используя формулу для расстояния между 
 * двумя точками на плоскости:
D=
Для нахождения площади треугольника со сторонами a, b, c 
использовать формулу Герона:
S = корень.кв(p·(p – a)·(p – b)·(p – c)),
где p = (a + b + c)/2 — полупериметр.
 * 
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3, a,b,c, S,P, p;
            Console.WriteLine("Введите координаты первой вершины треугольника:");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты второй вершины треугольника:");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты третьей вершины треугольника:");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());

            a = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            b = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            c = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            
            P = a + b + c;
            p = P / 2;
            
            S =Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Периметр треугольника ~" + Math.Round(P));
            Console.WriteLine("Площадь треугольника ~" + Math.Round(S));

        }
    }
}
