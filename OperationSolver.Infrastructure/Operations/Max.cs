using OperationsSolver.Application.Operations;

namespace OperationsSolver.Infrastructure.Operations
{
    internal class Max : IOperation
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Max();
        }
    }
}
