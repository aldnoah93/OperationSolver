using Microsoft.AspNetCore.Mvc;
using OperationsSolver.Logic.Solver;
using OperationsSolver.Models;
using System.Text.Json.Serialization;
using MvcJsonOptions = Microsoft.AspNetCore.Mvc.JsonOptions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region SwaggerEnumfix
/*
 * Quick fix to display enums as text instead of numbers
 * https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/2293
 */
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(o => o.SerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.Configure<MvcJsonOptions>(o => o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("/operationSolver/solve", async ([FromBody] Data data) => {
    IList<string> strings = new List<string>();
    await Task.WhenAll(new Solver().Solve(data, (string result) => strings.Add(result)));

    return String.Join("\n", strings);
});

app.Run();