using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OperationsSolver.Logic.IO
{
    public interface IReader<TOut>
    {
        TOut ReadFrom(string path, JsonSerializerOptions? options);
        TOut ReadFrom(string path);
    }
}
