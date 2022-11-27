using OperationsSolver.Application.Operations;
using OperationsSolver.Models;

namespace OperationsSolver.Infrastructure.Operations
{
    public class OperationFactory : IOperationFactory
    {
        public IOperation GetOperation(OperationType operationType)
        {
            IOperation operation = operationType switch
            {
                OperationType.Sum => new Sum(),
                OperationType.Average => new Average(),
                OperationType.Min => new Min(),
                OperationType.Max => new Max(),
                _ => throw new NotSupportedException("The operation is not supported!"),
            };
            return operation;
        }
    }
}
