using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeAbstract
{
    public abstract class Shape
    {
        public double Height { set; get; }
        public double Width { set; get; }
        public abstract double Area { get; }

        public abstract void Info();
    }
}
