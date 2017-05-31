using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeadReckoned.ULog
{
    public static class ILogDebugExtensions
    {
        public static bool IsDebugEnabled(this ILog logger)
        {
            return logger.IsEnabledFor(LogLevel.Debug);
        }

        public static void Debug(this ILog logger, string message)
        {
            logger.Log(LogLevel.Debug, message, null, null);
        }

        public static void Debug(this ILog logger, string message, Exception exception)
        {
            logger.Log(LogLevel.Debug, message, null, exception);
        }

        public static void Debug(this ILog logger, string message, UnityEngine.Object context)
        {
            logger.Log(LogLevel.Debug, message, context, null);
        }

        public static void Debug(this ILog logger, string message, UnityEngine.Object context, Exception exception)
        {
            logger.Log(LogLevel.Debug, message, context, exception);
        }

        public static void DebugFormat(this ILog logger, string message, object arg0)
        {
            logger.Log(LogLevel.Debug, string.Format(message, arg0), null, null);
        }

        public static void DebugFormat(this ILog logger, string message, object arg0, object arg1)
        {
            logger.Log(LogLevel.Debug, string.Format(message, arg0, arg1), null, null);
        }

        public static void DebugFormat(this ILog logger, string message, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Debug, string.Format(message, arg0, arg1, arg2), null, null);
        }

        public static void DebugFormat(this ILog logger, string message, params object[] args)
        {
            logger.Log(LogLevel.Debug, string.Format(message, args), null, null);
        }

        public static void DebugFormat(this ILog logger, UnityEngine.Object context, string message, object arg0)
        {
            logger.Log(LogLevel.Debug, string.Format(message, arg0), context, null);
        }

        public static void DebugFormat(this ILog logger, UnityEngine.Object context, string message, object arg0, object arg1)
        {
            logger.Log(LogLevel.Debug, string.Format(message, arg0, arg1), context, null);
        }

        public static void DebugFormat(this ILog logger, UnityEngine.Object context, string message, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Debug, string.Format(message, arg0, arg1, arg2), context, null);
        }

        public static void DebugFormat(this ILog logger, UnityEngine.Object context, string message, params object[] args)
        {
            logger.Log(LogLevel.Debug, string.Format(message, args), context, null);
        }
    }
}
