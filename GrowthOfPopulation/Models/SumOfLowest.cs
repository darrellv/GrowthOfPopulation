using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowthOfPopulation.Models
{
    public class SumOfLowest
    {
        private string low;
        public string strLowest
        {
            get
                { return low; }

            set
            {
                List<string> x = value.Split(",").ToList<string>();
                List<int> y = new List<int>();
                foreach (string i in x)
                {
                    string t = i.Replace("[","").Replace("]", "");
                    y.Add(Convert.ToInt32(t));
                }
                TwoLowest = y.ToArray();
                low = value;
            }
        }
        public int[] TwoLowest { get; set; }
        public int SumOfTwoLowest { get; set; }
   

        public SumOfLowest()
        {
        }

        public int SumTwoSmallestNumbers(int[] numbers)
        {
            int[] smalls = new int[] { 0, 0 };

            for (int x = 0; x < numbers.Length; x++)
            {
                if (x < 2)
                {
                    smalls[x] = numbers[x];
                }
                else
                {
                    if (numbers[x] < smalls[0])
                    {
                        if (smalls[0] < smalls[1])
                        {
                            smalls[1] = smalls[0];
                        }
                        smalls[0] = numbers[x];
                    }
                    else
                    {
                        if (numbers[x] < smalls[1])
                        {
                            smalls[1] = numbers[x];
                        }
                    }
                }
            }
            return smalls[0] + smalls[1];
        }
    }
}
