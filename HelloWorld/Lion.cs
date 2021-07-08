using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Lion : IAnimal
    {
        public int Age { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }

        public string Species => GetType().Name;

        public void GetDescription()
        {
            Console.WriteLine( Species );
        }

        public void RequestUniqueCharacteristic()
        {
            throw new NotImplementedException();
        }
    }
}
