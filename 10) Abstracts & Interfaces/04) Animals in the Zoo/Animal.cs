using System;
using System.Collections.Generic;
using System.Text;

namespace _04__Animals_in_the_Zoo
{
    abstract class Animal
    {
        protected string Name;
        protected int Age;
        protected string Gender;

        public virtual void Greet()
        {

        }

        public virtual string WantChild()
        {
            return "";
        }
    }
}
