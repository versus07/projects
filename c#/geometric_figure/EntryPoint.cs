using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using geometric_figure;



namespace geometric_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПРЯМОУГОЛЬНИК");
            Rectangle rec = new Rectangle(5, 4);
            Console.WriteLine($"Площадь прямоугольника со сторонами {rec.Height} на {rec.Width} равна " + rec.Area());
            Console.WriteLine($"Периметр прямоугольника со сторонами {rec.Height} на {rec.Width} равен " + rec.Perimetr());
            Console.WriteLine("---------------------------------\n");
            
            Console.WriteLine("ТРЕУГОЛЬНИК");
            Triangle tr = new Triangle(11, 4, 9);
            Console.WriteLine($"Площадь треугольника со сторонами {tr.A}, {tr.B}, {tr.C} равна " + tr.Area());
            Console.WriteLine($"Периметр треугольника со сторонами {tr.A}, {tr.B}, {tr.C} равен " + tr.Perimetr());
            Console.WriteLine("---------------------------------\n");

            Console.WriteLine("КВАДРАТ");
            Square sq = new Square(5);
            Console.WriteLine($"Площадь квадрата со стороной {sq.side} равна " + sq.Area());
            Console.WriteLine($"Периметр квадрата со стороной {sq.side} равен " + sq.Perimetr());
            Console.WriteLine("---------------------------------\n");
        }
    }
}
