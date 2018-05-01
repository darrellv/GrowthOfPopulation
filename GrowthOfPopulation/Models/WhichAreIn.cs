using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowthOfPopulation.Models
{
    public class WhichAreIn
    {
        private string[] m_a1;
        private string[] m_a2;
        public string A1 {
            get
            {
                return string.Join(",", m_a1);
            }
            set
            {
                m_a1 = value.Split(",");
            }
        }
        public string A2 {

            get
            {
                return string.Join(",", m_a2);
            }
            set
            {
                m_a2 = value.Split(",");
            }
        }

        public string[] r { get; set; }

        public WhichAreIn() { }

        public string[] inArray()
        {
            List<string> stringList = new List<string>();

            string mash = string.Join(",", m_a2);

            foreach (string x in m_a1)
            {
                if (mash.Contains(x.Trim()))
                {
                    if (!stringList.Contains(x.Trim()))
                    {
                        stringList.Add(x.Trim());
                    }
                }
            }

            stringList.Sort();
            r = stringList.ToArray<string>();

            return r;
        }
    }
}
