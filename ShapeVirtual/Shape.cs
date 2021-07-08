using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeVirtual
{
    public class Shape
    {
        public double Height { set; get; }
        public double Width { set; get; }
        public virtual double Area { get; }

        public virtual void Info()
        {
            Console.WriteLine("base class: This is a shape");
        }
    }
}
