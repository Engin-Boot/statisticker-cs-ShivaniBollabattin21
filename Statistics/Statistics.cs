using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Statistics
{
 
    public class StatsComputer
    {
        
        public Stats CalculateStatistics(List<float> numbers) {
            Stats _stats = new Stats();
            if(numbers.Count ==0)
            {
                _stats.Average = float.NaN;
                _stats.Max = float.NaN;
                _stats.Min = float.NaN;
            }
            else
            {
                float avg = numbers.Average();
                float max = numbers.Max();
                float min = numbers.Min();
                _stats.Average = avg;
                _stats.Max = max;
                _stats.Min = min;
                
            }
            return _stats;
        }
    }


    public class Stats
    {
        public float Average { get; set; }
        public float Max { get; set; }
        public float Min { get; set; }
    }

}
