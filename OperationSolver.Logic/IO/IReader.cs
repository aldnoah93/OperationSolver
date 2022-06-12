using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsSolver.Logic.IO
{
    public interface IReader<TOut>
    {
        TOut ReadFrom(string path);
    }
}
