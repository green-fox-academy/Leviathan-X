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
            if (ints.Count == 0 || ints == null) return 0;
            int sum = 0;

            foreach (var item in ints)
            {
                sum += item;
            }

            return sum;

        }
    }
}
