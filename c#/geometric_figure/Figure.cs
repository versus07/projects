using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace geometric_figure
{
   abstract class Figure
    {
        public abstract double Perimetr();
        public abstract double Area();
    }

    class Rectangle:Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimetr()
        {
            return (Width + Height) * 2;
        }
    }

    class Triangle:Figure
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public Triangle(float a, float b, float c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                Console.WriteLine("С данными сторонами треугольник не существует!");
            }

        }
        public override double Area()
        {
            double p;
            p = (A + B + C) / 2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }

        public override double Perimetr()
        {
            return A + B + C;
        }
    }

    class Square : Figure
    {
        public float side { get; set; }
        
        public Square(float a)
        {
            this.side = a;
        }
        public override double Area()
        {
            return Math.Pow(side,2);
        }
        public override double Perimetr()
        {
            return side * 4;
        }
    }
}
