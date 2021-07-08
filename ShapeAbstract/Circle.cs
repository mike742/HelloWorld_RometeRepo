using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeAbstract
{
    public class Circle : Shape
    {
        public override double Area { get => Math.Pow(Height / 2, 2) * Math.PI; }
        public Circle(double diameter)
        {
            Height = Width = diameter;
        }

        public override void Info()
        {
            throw new NotImplementedException();
        }
    }
}
