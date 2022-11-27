using OperationsSolver.Application.Operations;

namespace OperationsSolver.Infrastructure.Operations
{
    internal class Sum : IOperation
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Sum();
        }
    }
}
