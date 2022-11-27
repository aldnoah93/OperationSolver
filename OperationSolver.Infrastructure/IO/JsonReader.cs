using OperationsSolver.Application.IO;
using System.Text.Json;

namespace OperationsSolver.Infrastructure.IO
{
    /// <summary>
    /// Reads a json document from file directory
    /// </summary>
    /// <typeparam name="TOut">A given type to map from the json file</typeparam>
    public class JsonReader<TOut> : IReader<TOut>
    {
        /// <summary>
        /// Reads a given json document and returns an object representing the json content
        /// </summary>
        /// <param name="path">URI from file directory</param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"> Thrown if the json content is not valid based on the model class contract</exception>
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
