using OperationsSolver.Logic.Operations;
using OperationsSolver.Models;

namespace OperationsSolver.Logic.Solver
{
    public class Solver : ISolver
    {
        public IList<Task> Solve(Data data, Action<string> action)
        {
            var tasks = new List<Task>();
            foreach(var generator in data.Generators)
            {
                var task = Task.Run(async() =>
                {
                    IOperation<double> operation = OperationFactory(generator.Operation);
                    foreach(var values in data.Datasets)
                    {
                        var result = ApplyOperation(values, generator.Name, operation);
                        action(result);
                        await Task.Delay(generator.Interval * 1000);
                    }
                });
                tasks.Add(task);
            }
            return tasks;
        }

        public IOperation<double> OperationFactory(OperationType ot)
        {
            IOperation<double> operation = ot switch
            {
                OperationType.Sum => new Sum(),
                OperationType.Average => new Average(),
                OperationType.Min => new Min(),
                OperationType.Max => new Max(),
                _ => throw new NotSupportedException("The operation is not supported!"),
            };
            return operation;
        }
        private string ApplyOperation(IEnumerable<double> numbers, string operationName ,IOperation<double> operation)
        {
            return $"{GetTimeStamp(DateTime.Now)} {operationName} {operation.Calculate(numbers)}";
        }

        private string GetTimeStamp(DateTime date)
        {
            return date.ToString("HH:mm:ss");
        }
    }
}
