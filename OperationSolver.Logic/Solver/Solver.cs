using OperationsSolver.Logic.Operations;
using OperationsSolver.Models;

namespace OperationsSolver.Logic.Solver
{
    public class Solver
    {
        public void PrintSolution(Data _record)
        {
            foreach(var r in _record.Generators)
            {
                IOperation<double> operation;
                switch(r.Operation)
                {
                    case OperationType.Sum:
                        operation = new Sum();
                        break;
                    case OperationType.Average:
                        operation = new Average();
                        break;
                    case OperationType.Min:
                        operation = new Min();
                        break;
                    case OperationType.Max:
                        operation = new Max();
                        break;
                    default:
                        throw new NotSupportedException("The operation is not supported!");
                        break;
                }
            }
        }
    }
}
