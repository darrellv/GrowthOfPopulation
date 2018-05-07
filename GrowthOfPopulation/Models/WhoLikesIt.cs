using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowthOfPopulation.Models
{
    public class WhoLikesIt
    {
        public WhoLikesIt() { }

        public string Names { get; set; }

        public string Likes()
        {
            string[] n;
            if (Names == null)
            {
                n = new string[0];
            }
            else
            {
                n = Names.Split(",");
            }

            switch (n.Length)
            {
                case 0: return "no one likes this";
                case 1: return string.Format("{0} likes this", n[0]);
                case 2: return string.Format("{0} and {1} like this", n[0], n[1]);
                case 3: return string.Format("{0}, {1} and {2} like this", n[0], n[1], n[2]);
                default: return string.Format("{0}, {1} and {2} others like this", n[0], n[1], (n.Length - 2).ToString());
            }
        }
    }
}
