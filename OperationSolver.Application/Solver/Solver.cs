using OperationsSolver.Application.Operations;
using OperationsSolver.Models;

namespace OperationsSolver.Application.Solver
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

                    var size = data.Datasets.Count();
                    var enumerator = data.Datasets.GetEnumerator();
                    for (var i = 0; i < size; i++)
                    {
                        enumerator.MoveNext();
                        var values = enumerator.Current;
                        var operationResult = operation.Calculate(values);
                        var result = ApplyOperation(generator.Name, operationResult);
                        action(result);
                        if (i != size - 1)
                        {
                            await Task.Delay(generator.Interval * 1000);
                        }

                    }


                    //foreach (var values in data.Datasets)
                    //{
                    //    var operationResult = operation.Calculate(values);
                    //    var result = ApplyOperation(generator.Name, operationResult);
                    //    action(result);
                    //    await Task.Delay(generator.Interval * 1000);
                    //}
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
        private string ApplyOperation(string operationName , double operationResult)
        {
            return $"{DateTime.Now:HH:mm:ss} {operationName} {operationResult:#.##}";
        }
    }
}
