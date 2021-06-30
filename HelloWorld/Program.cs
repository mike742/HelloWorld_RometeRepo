using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double? salary = 112233;
            // double realSalary = salary == null ? 0 : (int)salary;
            double realSalary = salary ?? 0;

            //if (salary == null)
            //{
            //    realSalary = 0;
            //}
            //else
            //{
            //    realSalary = (int)salary;
            //}

            Console.WriteLine($"realSalary = {realSalary}");


            int? i1 = 7;  // 
            double? d = 0;
            decimal? m = 0;
            int a = 5;

            string str = null;


            bool? b = null; // true or false or null

            a = (int)i1;

            Console.WriteLine($"a = {a}");


            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"{i}, ");
                if (i == 100)
                    Console.Write($"{i}.");
                if (i % 15 == 0)
                    Console.WriteLine();

            }

        }
    }
}
