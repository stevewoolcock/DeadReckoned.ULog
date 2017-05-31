using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeadReckoned.ULog.Loggers
{
    internal interface ILogFactory
    {
        ILog CreateLogger(string name);
    }
}
