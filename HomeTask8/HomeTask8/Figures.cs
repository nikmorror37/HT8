using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    public abstract class Figures
    {
        //public abstract int Square { get; }
        //public abstract int Perimetr { get; }
        public abstract double SquareCount();
        public abstract double PerimetrCount();
    }

    class Triangle : Figures
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Height { get; set; }
        //double square;
        //double perimetr;
        //public Triangle(int aInit, int bInit, int cInit, int heightInit) //constructor
        //{
        //    a = aInit;
        //    b = bInit;
        //    c = cInit;
        //    height = heightInit;
        //}
        //public double Square { get; set; }
        //public double Perimetr { get; set; }
        public override double SquareCount() => C * Height / 2;

        public override double PerimetrCount() => A + B + C;

    }

    class Rectangle : Figures
    {
        public double X { get; set; }
        public double Y { get; set; }
        //double square;
        //double perimetr;
        //public Rectangle(int xInit, int yInit) //constructor
        //{
        //    x = xInit;
        //    y = yInit;
        //}
        //public int Square { get; set; }
        //public int Perimetr { get; set; }
        public override double SquareCount() => X * Y;
        public override double PerimetrCount() => (X + Y) * 2;

    }
    class Circle : Figures
    {
        public double R { get; set; }
        //double square;
        //double perimetr;
        //public override int Square { get; }
        //public override int Perimetr { get; }
        public override double SquareCount() => 3.14159 * R * R;

        public override double PerimetrCount() => 2 * 3.14159 * R;

    }














}
