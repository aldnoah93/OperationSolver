using OperationsSolver.Logic.Operations;

namespace OperationsSolver.Test.Logic.Operations
{
    public class MinTest
    {
        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5.5 }, 1)]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new double[] { 1, 2, 3, 4 }, 1)]
        public void Calculate_Min_Successfully(IEnumerable<double> input, double expectedResult)
        {
            Min operation = new();

            var result = operation.Calculate(input);

            Assert.Equal<double>(expectedResult, result);
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5.5 }, 6)]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new double[] { 1, 2, 3, 4 }, 3)]
        public void Calculate_Min_Not_Successfully(IEnumerable<double> input, double expectedResult)
        {
            Min operation = new();

            var result = operation.Calculate(input);

            Assert.NotEqual<double>(expectedResult, result);
        }
    }
}
