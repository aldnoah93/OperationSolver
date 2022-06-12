using OperationsSolver.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OperationsSolver.Logic.IO
{
    public class JsonReader : IReader<Data>
    {
        public Data ReadFrom(string path)
        {
            string jsonString = File.ReadAllText(path);

            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());

            var data = JsonSerializer.Deserialize<Data>(jsonString, options);

            if(data is null)
            {
                throw new NullReferenceException("Json could not be deserialized!");
            }
            return data;
        }
    }
}
