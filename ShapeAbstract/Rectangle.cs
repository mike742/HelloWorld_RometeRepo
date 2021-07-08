using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeAbstract
{
    public class Rectangle : Shape
    {
        public override double Area { get => Height * Width; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override void Info()
        {
            Console.WriteLine("child class: This is a Rectangle");
        }
    }
}
