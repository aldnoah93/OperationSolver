
using OperationsSolver.Application.IO;
using OperationsSolver.Application.Solver;
using OperationsSolver.Infrastructure.IO;
using OperationsSolver.Infrastructure.Operations;
using OperationsSolver.Models;

//var data = new Data()
//{
//    Datasets = new[]{
//        new []{ 1.4, 2, 3, 4},
//        new []{ 2, 3.7, 4 },
//        new [] {7, 8.87, 9, 10.01, 11 }
//    },
//    Generators = {
//        new Generator() {
//            Name = "Gen1",
//            Interval = 1,
//            Operation = OperationType.Sum
//        },
//        new Generator() {
//            Name = "Gen2",
//            Interval = 2,
//            Operation = OperationType.Min
//        }
//    }
//};

IReader<Data> reader = new JsonReader<Data>();

//var options = new JsonSerializerOptions();
//options.Converters.Add(new JsonStringEnumConverter());

var data = reader.ReadFrom("./data.json");

var operationFactory = new OperationFactory();

await Task.WhenAll(new Solver(operationFactory).Solve(data, Console.WriteLine));

