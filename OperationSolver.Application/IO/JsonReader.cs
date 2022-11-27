using OperationsSolver.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OperationsSolver.Application.IO
{
    public class JsonReader<TOut> : IReader<TOut>
    {
        public TOut ReadFrom(string path)
        {
            ReadOnlySpan<char> jsonString = File.ReadAllText(path);

            var data = JsonSerializer.Deserialize<TOut>(jsonString);

            if(data is null)
            {
                throw new NullReferenceException($"Json of type {{typeof(TOut)}} could not be deserialized!");
            }
            return data;
        }
    }
}
