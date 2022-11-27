using OperationsSolver.Application.Operations;
using OperationsSolver.Models;

namespace OperationsSolver.Infrastructure.Operations
{
    public class OperationFactory : IOperationFactory
    {
        private readonly IDictionary<OperationType, IOperation> _operations = new Dictionary<OperationType, IOperation>();

        public IOperation GetOperation(OperationType operationType)
        {
            IOperation? operation;

            if (_operations.TryGetValue(operationType, out operation))
            {
                return operation;
            }

            operation = operationType switch
            {
                OperationType.Sum => new Sum(),
                OperationType.Average => new Average(),
                OperationType.Min => new Min(),
                OperationType.Max => new Max(),
                _ => throw new NotSupportedException("The operation is not supported!"),
            };

            _operations[operationType] = operation;

            return operation;
        }
    }
}
