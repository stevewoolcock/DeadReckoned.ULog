using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeadReckoned.ULog.Loggers;

namespace DeadReckoned.ULog.Logs
{
    internal sealed class UnityLogFactory : ILogFactory
    {
        public ILog CreateLogger(string name)
        {
            return new UnityLog(name);
        }
    }
}
