using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Animal
    {
        public int Age { get; set; }

        public string Species => GetType().Name.ToLower();

        public void SetAge() 
        {
            Console.WriteLine(" How old is it? ");
            Age = Int32.Parse( Console.ReadLine() );
        }
    }
}
