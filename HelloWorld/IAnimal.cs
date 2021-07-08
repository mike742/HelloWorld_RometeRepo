using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public interface IAnimal
    {
        int Age { set; get; }
        string Species { get;}
        void RequestUniqueCharacteristic();
        void GetDescription();
    }
}
