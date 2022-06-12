using System.Runtime.Serialization;

namespace OperationsSolver.Models
{
    public enum OperationType
    {
        [EnumMember(Value = "sum")]
        Sum,
        [EnumMember(Value = "Average")]
        Average,
        [EnumMember(Value = "min")]
        Min,
        [EnumMember(Value = "Max")]
        Max
    }

    public class Generator
    {
        public string Name { get; set; } = string.Empty;
        public int Interval { get; set; }
        public OperationType Operation { get; set; }
    }
}
