using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace OperationsSolver.Models
{
    public enum OperationType
    {
        [EnumMember(Value = "sum")]
        Sum,
        [EnumMember(Value = "average")]
        Average,
        [EnumMember(Value = "min")]
        Min,
        [EnumMember(Value = "max")]
        Max
    }

    public class Generator
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("interval")]
        public int Interval { get; set; }
        [JsonPropertyName("operation")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OperationType Operation { get; set; }
    }
}
