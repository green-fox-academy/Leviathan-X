using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02__Sum
{
    class Summie
    {
        public Summie()
        {

        }

        public int Sum(List<int> ints)
        {
            int sum = 0;

            foreach (var item in ints)
            {
                sum += item;
            }

            return sum;
        }
    }
}
