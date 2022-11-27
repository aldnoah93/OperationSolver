using OperationsSolver.Models;

namespace OperationsSolver.Application.Operations
{
    public interface IOperationFactory
    {
        IOperation GetOperation(OperationType operationType);
    }
}
