namespace OperationsSolver.Logic.Operations
{
    public interface IOperation<T>
    {
        T Calculate(IEnumerable<T> input);
    }
}
