using System;
using System.Linq;
using static System.Console;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123456hello";
            // int intValue1 = Int32.Parse(str);
            // WriteLine($"intValue1 = {intValue1}");

            int intValue2;
            bool res = Int32.TryParse(str, out intValue2);

            if (res)
            {
                WriteLine($"intValue2 = {intValue2}");
            }
            else
                WriteLine("Something wrong");

            int i = 1;
            RefMethod(ref i);
            WriteLine($"i = {i}");

            OutMethod(out i);
            WriteLine($"i = {i}");

            double pi = 3.14;
            int r = 10;

            InMethod(r, in pi);


            int[] arr = { 4, 1, 7, 2, 9, 3 };
            Array.Sort(arr);

            WriteLine(  string.Join(", ", arr) );
        }

        static void RefMethod(ref int a)
        {
            //a = 77;
        }

        static void OutMethod(out int a)
        {
            a = 777;
        }

        static void InMethod(int r, in double pi)
        {
            // pi = 3.15;
            WriteLine(r * r * pi);
        }
    }
}
