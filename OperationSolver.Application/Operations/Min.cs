namespace OperationsSolver.Application.Operations
{
    internal class Min : IOperation
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Min();
        }
    }
}
