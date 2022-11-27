namespace OperationsSolver.Application.Operations
{
    public interface IOperation<T>
    {
        T Calculate(IEnumerable<T> input);
    }
}
