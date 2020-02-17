using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        public override double CalcArea()
        {
            return length * width;
        }

        public override double CalcPerimeter()
        {
            return 2 * length + 2 * width;
        }
    }
}