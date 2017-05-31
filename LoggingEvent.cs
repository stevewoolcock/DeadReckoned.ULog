using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeadReckoned.ULog
{
    internal struct LoggingEvent
    {
        public string LoggerName;
        public LogLevel Level;
        public string Message;
        public Exception Exception;
        public UnityEngine.Object Context;
    }
}
