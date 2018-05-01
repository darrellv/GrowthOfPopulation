using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowthOfPopulation.Models
{
    public class PopulationData
    {
        public int Population { get; set; }
        public double Percent { get; set; }
        public int InhabitantChange { get; set; }
        public int PopulationToSurpass { get; set; }
        public int Years { get; set; }

        public PopulationData()
        {
        }

        public int YearsToReachPopToSurpass()
        {
            if ((Population <= 0)||(PopulationToSurpass <= 0))
            {
                throw new ApplicationException("Population and PopulationToSurpass must be greater than 0");
            }

            int x = 0;

            while (Population < PopulationToSurpass)
            {
                Population = Population + Convert.ToInt32(Math.Floor(Convert.ToDecimal((Population * (Percent * 0.01))))) + InhabitantChange;
                x++;
            }
            Years = x;
            return x;
        }
    }
}
