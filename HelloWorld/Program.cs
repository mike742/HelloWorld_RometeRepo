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
            Shape r = new Rectangle(20, 15);

            r.Width = 50;

            Console.WriteLine($"area of r = {((Rectangle)r).Area}");

            ((Rectangle)r).Info();


            Circle c = new Circle(100);
            Console.WriteLine($"area of a circle = {c.Area}");

            Console.WriteLine("==================================");










            Customer c1 = new Customer();
            c1.PrintFullName();

            Console.WriteLine(Customer.GetClassName());

            Customer.SetClassName("Customer class");

            Console.WriteLine(Customer.GetClassName());

            c1.Salary = 1500.55;
            Console.WriteLine("salary = ${0}", c1.Salary);
        }
    }
}
