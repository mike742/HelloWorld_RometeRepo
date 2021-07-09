using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Wolf : Animal, IAnimal
    {
        public void GetDescription()
        {
            Console.WriteLine("Species: " + Species + " with speed. " + Age + " years-old");
        }

        public void RequestUniqueCharacteristic()
        {
            throw new NotImplementedException();
        }
    }
}
