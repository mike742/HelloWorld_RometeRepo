﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Lion : Animal, IAnimal
    {
        public void GetDescription()
        {
            Console.WriteLine("Species: " + Species + " with mane. " 
                + Age + " years-old");
        }

        public void RequestUniqueCharacteristic()
        {
            throw new NotImplementedException();
        }
    }
}
