using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeadReckoned.ULog
{
    public interface ILog
    {
        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="level">The logging level for the message.</param>
        /// <param name="message">The message to log.</param>
        /// <param name="context">The context of the message.</param>
        /// <param name="exception">An optional Exception to log along with the message.</param>
        void Log(LogLevel level, string message, UnityEngine.Object context, Exception exception = null);
        
        /// <summary>
        /// Determines if the specified log level is enabled.
        /// </summary>
        /// <param name="level">The <see cref="LogLevel"/> to test.</param>
        /// <returns>A boolean indicating if the specified <see cref="LogLevel"/> is currently enabled.</returns>
        bool IsEnabledFor(LogLevel level);
    }
}
