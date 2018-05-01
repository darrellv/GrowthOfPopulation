using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowthOfPopulation.Models
{
    public class Duplicates
    {
        public string InputString { get; set; }

        public Duplicates()
        {
        }

        public int GetDuplicateCount(string str)
        {
            str = str.ToLower();

            IEnumerable<char> query = str.GroupBy(keySelector: x => x)
                                            .Where(y => y.Count() > 1)
                                            .Select(y => y.Key);

            return query.Count();

        }
    }
}
