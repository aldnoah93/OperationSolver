using System.Text.Json.Serialization;

namespace OperationsSolver.Models
{
    public class Data
    {
        [JsonPropertyName("datasets")]
        public IEnumerable<IEnumerable<double>> Datasets { get; set; } = new List<IEnumerable<double>>();

        [JsonPropertyName("generators")]
        public IList<Generator> Generators { get; set; } = new List<Generator>();
    }
}
