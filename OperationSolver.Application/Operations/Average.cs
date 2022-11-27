namespace OperationsSolver.Application.Operations
{
    internal class Average : IOperation
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Average();
        }
    }
}
