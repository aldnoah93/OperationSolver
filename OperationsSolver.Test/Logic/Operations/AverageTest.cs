using OperationsSolver.Application.Operations;

namespace OperationsSolver.Test.Logic.Operations
{
    public class AverageTest
    {
        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5.5 }, 3.1)]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new double[] { 1, 2, 3, 4 }, 2.5)]
        public void Calculate_Average_Successfully(IEnumerable<double> input, double expectedResult)
        {
            Average operation = new();

            var result = operation.Calculate(input);

            Assert.Equal<double>(expectedResult, result);
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5.5 }, 3)]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, 3.5)]
        [InlineData(new double[] { 1, 2, 3, 4 }, 2.6)]
        public void Calculate_Average_Not_Successfully(IEnumerable<double> input, double expectedResult)
        {
            Average operation = new();

            var result = operation.Calculate(input);

            Assert.NotEqual<double>(expectedResult, result);
        }
    }
}
