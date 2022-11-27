using System.Text.Json;

namespace OperationsSolver.Application.IO
{
    public interface IReader<TOut>
    {
        TOut ReadFrom(string path);
    }
}
