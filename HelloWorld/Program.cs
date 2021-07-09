using Shapes;
using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //ConsoleKeyInfo keyInfo;

            //Console.WriteLine("Enter a string. Press <Enter> or Esc to exit.");
            //keyInfo = Console.ReadKey(true);
            //Console.Write(keyInfo.KeyChar);

            //if (keyInfo.Key == ConsoleKey.C)
            //{
            //    Console.WriteLine("The Esc key pressed");
            //}


            // S O L I D
            List<IAnimal> list = new List<IAnimal>();


            Lion lion = new Lion();
            // Lion lion2 = new Lion();
            lion.SetAge();
            list.Add(lion);

            Wolf wolf = new Wolf();
            wolf.SetAge();
            list.Add(wolf);




            foreach (var animal in list)
            {
                animal.GetDescription();
            }
        }
    }
}
