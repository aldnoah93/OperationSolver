using OperationsSolver.Application.Operations;

namespace OperationsSolver.Infrastructure.Operations
{
    internal class Average : IOperation
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Average();
        }
    }
}
