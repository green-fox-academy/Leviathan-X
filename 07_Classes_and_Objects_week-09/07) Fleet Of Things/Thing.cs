using System;
using System.Collections.Generic;
using System.Text;

namespace _07__Fleet_Of_Things
{
    class Thing
    {
        private string name;
        private bool completed;

        public Thing(string name)
        {
            this.name = name;
        }

        public void Complete()
        {
            completed = true;
        }

        public string Status()
        {
            if (completed == true)
            {
                return "x";
            }
            else return " "; 
        }

        public string GetName()
        {
            return name;
        }
    }
}
