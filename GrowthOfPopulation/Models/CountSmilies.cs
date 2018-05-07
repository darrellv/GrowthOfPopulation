using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GrowthOfPopulation.Models
{
    public class CountSmilies
    {
        public CountSmilies() { }

        public string SmiliesIn { get; set; }

        public string[] ConvertStringToArray(string smilies)
        {
            if (smilies == null)
            {
                return new string[0];
            }
            else
            {
                return smilies.Split(",");
            }
        }

        public int CountSmileys(string[] smileys)
        {
            string regExPattern = "[:;][~-]?[\\)D]+";

            int result = 0;

            foreach (string x in smileys)
            {
                Match m = Regex.Match(x, regExPattern);
                if (m.Length > 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
