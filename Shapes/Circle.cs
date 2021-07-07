using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public new double Area { get => Math.Pow(Height / 2, 2) * Math.PI; }
        public Circle(double diameter)
        {
            Height = Width = diameter;
        }
    }
}
