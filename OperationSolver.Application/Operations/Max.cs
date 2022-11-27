namespace OperationsSolver.Application.Operations
{
    internal class Max : IOperation
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Max();
        }
    }
}
