namespace OperationsSolver.Application.Operations
{
    public class Average : IOperation<double>
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Average();
        }
    }
}
