using Serilog;
using System;
using System.Linq;
using static System.Console;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("app.log")
                .CreateLogger();

            Log.Information("Hello world!");
            Log.Fatal("Really Bad!!");
            Log.Error("An Error");


            // Task_02.SortByHeight(new int[] { -1, 150, 190, 170, -1, -1, 160, 180 });
            Console.WriteLine(string.Join(", ", Task_02.SortByHeight(null)));














            try
            {
                string input = "12333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333";
                int intInput1 = Int32.Parse(input);

                if (intInput1 < 0 || intInput1 > 255)
                    throw new ArgumentOutOfRangeException();


                input = "0";
                int intInput2 = Int32.Parse(input);


                WriteLine(intInput1 / intInput2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                WriteLine("Null Arg");
            }
            catch (OverflowException e)
            {
                WriteLine("Your number was toooooooooooooooooo big");
            }
            catch (Exception e)
            {
                WriteLine("Something wrong!!!!");
            }
        }
    }
}
