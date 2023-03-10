using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    public abstract class Figures
    {
        public abstract double SquareCount();
        public abstract double PerimetrCount();
    }

    class Triangle : Figures
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Height { get; set; }
        public override double SquareCount() => C * Height / 2;

        public override double PerimetrCount() => A + B + C;

    }

    class Rectangle : Figures
    {
        public double X { get; set; }
        public double Y { get; set; }
        public override double SquareCount() => X * Y;
        public override double PerimetrCount() => (X + Y) * 2;

    }
    class Circle : Figures
    {
        public double R { get; set; }
        public override double SquareCount() => 3.14159 * R * R;

        public override double PerimetrCount() => 2 * 3.14159 * R;

    }














}
