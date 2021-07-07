using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Shape
    {
        public double Height { set; get; }
        public double Width { set; get; }
        public double Area { get; }

        public void Info()
        {
            Console.WriteLine("base class: This is a shape");
        }
    }
}
