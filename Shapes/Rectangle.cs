using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public new double Area { get => Height * Width; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public new void Info()
        {
            Console.WriteLine("child class: This is a Rectangle");
        }
    }
}
