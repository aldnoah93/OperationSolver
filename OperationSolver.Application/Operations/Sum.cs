namespace OperationsSolver.Application.Operations
{
    public class Sum : IOperation<double>
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Sum();
        }
    }
}
