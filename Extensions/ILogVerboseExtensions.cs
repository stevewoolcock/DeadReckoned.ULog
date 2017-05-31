using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeadReckoned.ULog
{
    public static class ILogVerboseExtensions
    {
        public static bool IsVerboseEnabled(this ILog logger)
        {
            return logger.IsEnabledFor(LogLevel.Verbose);
        }

        public static void Verbose(this ILog logger, string message)
        {
            logger.Log(LogLevel.Verbose, message, null, null);
        }

        public static void Verbose(this ILog logger, string message, Exception exception)
        {
            logger.Log(LogLevel.Verbose, message, null, exception);
        }

        public static void Verbose(this ILog logger, string message, UnityEngine.Object context)
        {
            logger.Log(LogLevel.Verbose, message, context, null);
        }

        public static void Verbose(this ILog logger, string message, UnityEngine.Object context, Exception exception)
        {
            logger.Log(LogLevel.Verbose, message, context, exception);
        }

        public static void VerboseFormat(this ILog logger, string message, object arg0)
        {
            logger.Log(LogLevel.Verbose, string.Format(message, arg0), null, null);
        }

        public static void VerboseFormat(this ILog logger, string message, object arg0, object arg1)
        {
            logger.Log(LogLevel.Verbose, string.Format(message, arg0, arg1), null, null);
        }

        public static void VerboseFormat(this ILog logger, string message, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Verbose, string.Format(message, arg0, arg1, arg2), null, null);
        }

        public static void VerboseFormat(this ILog logger, string message, params object[] args)
        {
            logger.Log(LogLevel.Verbose, string.Format(message, args), null, null);
        }

        public static void VerboseFormat(this ILog logger, UnityEngine.Object context, string message, object arg0)
        {
            logger.Log(LogLevel.Verbose, string.Format(message, arg0), context, null);
        }

        public static void VerboseFormat(this ILog logger, UnityEngine.Object context, string message, object arg0, object arg1)
        {
            logger.Log(LogLevel.Verbose, string.Format(message, arg0, arg1), context, null);
        }

        public static void VerboseFormat(this ILog logger, UnityEngine.Object context, string message, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Verbose, string.Format(message, arg0, arg1, arg2), context, null);
        }

        public static void VerboseFormat(this ILog logger, UnityEngine.Object context, string message, params object[] args)
        {
            logger.Log(LogLevel.Verbose, string.Format(message, args), context, null);
        }
    }
}
