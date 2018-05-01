using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowthOfPopulation.Models
{
    public class SumOfNumbers
    {
        public SumOfNumbers() { }

        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int GetSum(int a, int b)
        {
            if (a > b)
            {
                int r = a;
                a = b;
                b = r;
            }

            int total = 0;

            for (int x = a; x <= b; x++)
            {
                total += x;
            }
            return total;
        }
    }
}
