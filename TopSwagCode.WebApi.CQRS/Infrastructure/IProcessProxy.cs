using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopSwagCode.WebApi.CQRS.Infrastructure
{
    public interface IProcessProxy
    {
        string RunCommand(string cmd, string arguments);
    }

    public class ProcessProxy : IProcessProxy
    {
        public string RunCommand(string cmd, string arguments)
        {
            return $"Hello world: {cmd} + {arguments}";
        }
    }
}
