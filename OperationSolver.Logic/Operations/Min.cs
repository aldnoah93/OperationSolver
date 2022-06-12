namespace OperationsSolver.Logic.Operations
{
    public class Min : IOperation<double>
    {
        public double Calculate(IEnumerable<double> input)
        {
            return input.Min();
        }
    }
}
