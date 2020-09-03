using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            List<float> numbers = new List<float>() { 1.5f, 8.9f, 3.2f, 4.5f};
            var computedStats = statsComputer.CalculateStatistics(numbers);
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average- 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max- 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 1.5) <= epsilon);
        }
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{});
            Assert.True(computedStats.Average == float.NaN);
            Assert.True(computedStats.Max == float.NaN);
            Assert.True(computedStats.Min == float.NaN);

            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
    }
}
