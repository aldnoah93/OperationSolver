namespace OperationsSolver.Application.Operations
{
    public class Max : IOperation<double>
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Max();
        }
    }
}
