using OperationsSolver.Logic.Operations;

namespace OperationsSolver.Test.Logic.Operations
{
    public class SumTest
    {

        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5.5 }, 15.5)]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, 15.0)]
        [InlineData(new double[] { 1, 2, 3, 4 }, 10)]
        public void Calculate_Sum_Successfully(IEnumerable<double> input,double expectedResult)
        {
            IOperation<double> operation = new Sum();

            var result = operation.Calculate(input);

            Assert.Equal<double>(expectedResult, result);
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5.5 }, 16.5)]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, 16.0)]
        [InlineData(new double[] { 1, 2, 3, 4 }, 11)]
        public void Calculate_Sum_Not_Successfully(IEnumerable<double> input, double expectedResult)
        {
            IOperation<double> operation = new Sum();

            var result = operation.Calculate(input);

            Assert.NotEqual<double>(expectedResult, result);
        }
    }
}
