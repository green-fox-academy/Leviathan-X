using System;
using System.Collections.Generic;
using System.Text;

namespace _05__Flyable
{
    abstract class Helicopter : Vehicle, IFlyable
    {
        public void fly()
        {
            throw new NotImplementedException();
        }

        public void land()
        {
            throw new NotImplementedException();
        }

        public void takeOff()
        {
            throw new NotImplementedException();
        }
    }
}
