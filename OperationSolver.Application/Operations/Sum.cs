namespace OperationsSolver.Application.Operations
{
    internal class Sum : IOperation
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Sum();
        }
    }
}
