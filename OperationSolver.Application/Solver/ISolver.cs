using OperationsSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsSolver.Application.Solver
{
    public interface ISolver
    {
        public IList<Task> Solve(Data data, Action<string> action);
    }
}
