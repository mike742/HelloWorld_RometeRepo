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

            int count = 100;
            int line = 15;
            for (int i = 1; i <= count; i++)
            {
                /*
                 * here is a logic
                 */
                //Console.Write($"{i}, ");
                //if (i == count)
                //    Console.Write($"{i}.");
                //else
                //    Console.Write($"{i}, ");
                Console.Write($"{i}{(i == count ? "." : ", ")}");

                if (i % line == 0)
                    Console.WriteLine();

            }

            Console.WriteLine("\n==================================\n");
            // Arrays
            int[] evenNumbers = new int[10];
            // 0 0 0 0 0 0  0  0  0 0 - array
            // 0 1 2 3 4 5  6  7  8 9 - indexes
            // 0 2 4 6 8 10 12 14 16...

            string res  = String.Join(',', evenNumbers);     

            Console.WriteLine(res);

            for (int i = 0; i < evenNumbers.Length; ++i)
            {
                evenNumbers[i] = i * 2;
                //Console.Write(evenNumbers[i] + " ");
            }

            //res = String.Join(',', evenNumbers);
            Console.WriteLine(String.Join(',', evenNumbers) + ".");

            //foreach (var el in evenNumbers)
            //{
            //    Console.Write($"{el} ");
            //}


            string[] arrStr = { "1", "2", "Fizz", "\n4", "Buzz"};

            Console.WriteLine(string.Join(", ", arrStr) + ".");
        }
    }
}
