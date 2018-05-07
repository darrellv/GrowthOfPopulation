using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowthOfPopulation.Models
{
    public class MoveZeroesToEnd
    {
        public MoveZeroesToEnd() { }

        public string NumberList { get; set; }

        public int[] ConvertNumberStringToArray(string numList)
        {
            if (numList == "")
            {
                return new int[0];
            }
            else
            {
                string[] x = numList.Split(",");
                int[] numListInts = new int[x.Length];
                for(int y = 0; y < x.Length; y++)
                {
                    numListInts[y] = Convert.ToInt32(x[y]);
                }

                return numListInts;
            }
        }

        public string CovertArrayToString(int[] arr)
        {
            string output = "";
            foreach (int x in arr)
            {
                output += string.Format("{0}, ", Convert.ToString(x));
            }
            return output.TrimEnd(',', ' ');
        }

        public int[] MoveZeroes(int[] arr)
        {
            bool done = false;

            int count = 0;

            if ((arr.All(element => element == 0)) || (arr.All(element => element != 0)))
            {
                done = true;
            }
            else
            {
                for (int y = 0; y < arr.Length; y++)
                {
                    if (arr[y] != 0)
                    {
                        count++;
                    }

                }
            }

            while (!done)
            {
                for (int x = 0; x < arr.Length - 1; x++)
                {
                    if (arr[x] == 0)
                    {
                        arr[x] = arr[x + 1];
                        arr[x + 1] = 0;
                    }
                }
                done = true;
                for (int x = 0; x < count; x++)
                {
                    if ((arr[x] == 0))
                    {
                        done = false;
                    }
                }
            }

            return arr;
        }
    }
}
