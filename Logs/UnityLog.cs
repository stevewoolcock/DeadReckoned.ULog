using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeadReckoned.ULog.Loggers;

namespace DeadReckoned.ULog.Logs
{
    internal sealed class UnityLog : ILog
    {
        private const string _template = "[{0}] {1}";

        private readonly string mName;

        public UnityLog(string name)
        {
            mName = name;
        }
        
        public bool IsEnabledFor(LogLevel level)
        {
            return LogManager.Config.IsLogLevelEnabled(level);
        }

        public void Log(LogLevel level, string message, UnityEngine.Object context, Exception exception = null)
        {
            Log(new LoggingEvent()
            {
                LoggerName = mName,
                Level = level,
                Message = message,
                Context = context,
                Exception = exception,
            });
        }

        private void Log(LoggingEvent ev)
        {
            var message = string.Format(_template, ev.LoggerName, ev.Message);
            switch (ev.Level)
            {
                case LogLevel.Assert:
                    UnityEngine.Debug.LogAssertion(message, ev.Context);
                    break;

                case LogLevel.Fatal:
                    UnityEngine.Debug.LogError(message, ev.Context);
                    break;

                case LogLevel.Error:
                    UnityEngine.Debug.LogError(message, ev.Context);
                    break;

                case LogLevel.Warn:
                    UnityEngine.Debug.LogWarning(message, ev.Context);
                    break;
                    
                case LogLevel.Verbose:
                case LogLevel.Debug:
                case LogLevel.Info:
                default:
                    UnityEngine.Debug.Log(message, ev.Context);
                    break;
            }

            if (ev.Exception != null)
            {
                UnityEngine.Debug.LogException(ev.Exception, ev.Context);
            }
        }
    }
}