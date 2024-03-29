﻿using OperationsSolver.Application.Operations;
using OperationsSolver.Models;

namespace OperationsSolver.Application.Solver
{
    public class Solver : ISolver
    {
        public readonly IOperationFactory _operationFactory;

        public Solver(IOperationFactory operationFactory)
        {
            _operationFactory = operationFactory;
        }

        public IList<Task> Solve(Data data, Action<string> action)
        {
            var tasks = new List<Task>();
            foreach(var generator in data.Generators)
            {
                var task = Task.Run(async() =>
                {
                    IOperation operation = _operationFactory.GetOperation(generator.Operation);

                    var size = data.Datasets.Count();
                    var enumerator = data.Datasets.GetEnumerator();
                    for (var i = 0; i < size; i++)
                    {
                        enumerator.MoveNext();
                        var values = enumerator.Current;
                        var operationResult = operation.Calculate(values);
                        var result = ApplyResultFormat(generator.Name, operationResult);
                        action(result);
                        if (i != size - 1)
                        {
                            await Task.Delay(generator.Interval * 1000);
                        }

                    }
                });
                tasks.Add(task);
            }
            return tasks;
        }

        private static string ApplyResultFormat(string operationName , double operationResult)
        {
            return $"{DateTime.Now:HH:mm:ss} {operationName} {operationResult:#.##}";
        }
    }
}
