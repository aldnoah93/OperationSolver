
using OperationsSolver.Logic.Solver;
using OperationsSolver.Models;

var data = new Data()
{
    Datasets = new[]{
        new []{ 1.4, 2, 3, 4},
        new []{ 2, 3.7, 4 },
        new [] {7, 8.87, 9, 10.01, 11 }
    },
    Generators = {
        new Generator() {
            Name = "Gen1",
            Interval = 1,
            Operation = OperationType.Sum
        },
        new Generator() {
            Name = "Gen2",
            Interval = 2,
            Operation = OperationType.Min
        }
    }
};


await Task.WhenAll(Solver.Solve(data, Console.WriteLine));

