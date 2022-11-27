using OperationsSolver.Application.Operations;

namespace OperationsSolver.Infrastructure.Operations
{
    internal class Min : IOperation
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Min();
        }
    }
}
