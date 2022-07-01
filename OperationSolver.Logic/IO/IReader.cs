using System.Text.Json;

namespace OperationsSolver.Logic.IO
{
    public interface IReader<TOut>
    {
        TOut ReadFrom(string path);
    }
}
