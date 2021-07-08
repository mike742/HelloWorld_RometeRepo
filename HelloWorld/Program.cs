using Shapes;
using System;

namespace HelloWorld
{
    class Customer
    {
        private string _firstName = "N/A";
        private string _lastName = "N/A";

        private static string className;

        public static string GetClassName() => className;
        public static void SetClassName(string value) => className = value;


        private double _salary;

        public double Salary {
            get => _salary;
            set => _salary = value;
        }

        static Customer()
        {
            Console.WriteLine("Static cunstructor called");
            className = "classCustomer";
        }

        public Customer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public Customer() { }
        // public Customer() : this(null, null) { }

        public void PrintFullName()
        {
            Console.WriteLine($"{_firstName} {_lastName}");
        }

        public override string ToString() => $"{_firstName} {_lastName}";

        public void DisplayName() => Console.WriteLine(ToString());
        
    }



    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            Shape r = new Rectangle(20, 15);

            shapes[0] = r;

            r.Width = 50;

            Console.WriteLine($"area of r = {r.Area}");
            Console.WriteLine($"area of r = {((Rectangle)r).Area}");

            ((Rectangle)r).Info();


            Circle c = new Circle(100);
            Console.WriteLine($"area of a circle = {c.Area}");

            shapes[1] = c;

            Console.WriteLine("==================================");

            foreach (var shape in shapes)
            {
                if (shape != null)
                {
                    // Console.WriteLine(shape.GetType().Name + " " + shape.Area);
                    
                    if(shape.GetType() == typeof(Rectangle))
                        Console.WriteLine(((Rectangle)shape).Area);
                    if (shape.GetType() == typeof( Circle))
                       Console.WriteLine(((Circle)shape).Area);
                }
            }
            Console.WriteLine("=============== Virtual ===================");
            ShapeVirtual.Shape shv = new ShapeVirtual.Shape();

            ShapeVirtual.Shape[] shapes2 = new ShapeVirtual.Shape[2];
            
            ShapeVirtual.Shape r2 = new ShapeVirtual.Rectangle(5, 7);
            ShapeVirtual.Shape c2 = new ShapeVirtual.Circle(7);

            shapes2[0] = r2;
            shapes2[1] = c2;

            foreach (var shape in shapes2)
            {
                Console.WriteLine(shape.Area);
            }

            Console.WriteLine("============== Abstract ====================");
            ShapeAbstract.Shape[] shapes3 = new ShapeAbstract.Shape[2];

            ShapeAbstract.Shape r3 = new ShapeAbstract.Rectangle(25, 10);
            ShapeAbstract.Shape c3 = new ShapeAbstract.Circle(50);

            shapes3[0] = r3;
            shapes3[1] = c3;

            foreach (var shape in shapes3)
            {
                Console.WriteLine(shape.Area);
            }

            // S O L I D

            IAnimal lion = new Lion();
            // Lion lion2 = new Lion();

            Console.WriteLine( lion.Species );
            lion.GetDescription();
        }
    }
}
