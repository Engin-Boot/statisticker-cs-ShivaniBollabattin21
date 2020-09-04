using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void TestAverageMinMaxForAListOfFloatValues()
        {
            var statsComputer = new StatsComputer();
            List<float> numbers = new List<float>() { 1.5f, 8.9f, 3.2f, 4.5f};
            var computedStats = statsComputer.CalculateStatistics(numbers);
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average- 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max- 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{});
            Assert.True( float.IsNaN(computedStats.Average));
            Assert.True(float.IsNaN(computedStats.Max));
            Assert.True(float.IsNaN(computedStats.Min));

            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
        [Fact]
        public void ReportNaNForListHavingAllNaNElements()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float> { float.NaN,float.NaN});
            Assert.True(float.IsNaN(computedStats.Average));
            Assert.True(float.IsNaN(computedStats.Max));
            Assert.True(float.IsNaN(computedStats.Min));
            

        }
        [Fact]
        public void TestForListHavingSomeElementsAsNaN()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float> { float.NaN, 1.5F, 8.9F, 3.2F, 4.5F });
            float epsilon = 0.001F;
            Assert.True(float.IsNaN(computedStats.Average));
            Assert.True(Math.Abs(computedStats.Max - 8.9) <= epsilon);
            Assert.True(float.IsNaN(computedStats.Min));
            

        }
    }
}
