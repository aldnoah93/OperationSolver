namespace OperationsSolver.Application.Operations
{
    public interface IOperation
    {
        double Calculate(IEnumerable<double> input);
    }
}
