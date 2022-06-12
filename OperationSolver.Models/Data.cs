namespace OperationsSolver.Models
{
    public class Data
    {
        public IEnumerable<IEnumerable<double>> Datasets { get; set; } = new List<IEnumerable<double>>();
        public IList<Generator> Generators { get; set; } = new List<Generator>();
    }
}
