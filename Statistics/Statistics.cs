using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public float Average { get;  set; }
        public float Max { get; set; }
        public float Min { get; set; }



        public StatsComputer CalculateStatistics(List<float> numbers) {
            StatsComputer stats = new StatsComputer();
            if(numbers.Count ==0)
            {
                stats.Average = float.NaN;
                stats.Max = float.NaN;
                stats.Min = float.NaN;
            }
            else
            {
                float avg = numbers.Average();
                float max = numbers.Max();
                float min = numbers.Min();
                stats.Average = avg;
                stats.Max = max;
                stats.Min = min;
                
            }
            return stats;
        }
    }
}
