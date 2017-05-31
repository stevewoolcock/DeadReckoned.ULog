using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeadReckoned.ULog.Loggers;
using DeadReckoned.ULog.Logs;

namespace DeadReckoned.ULog
{
    public static class LogManager
    {
        private static readonly Dictionary<string, ILog> _loggers = new Dictionary<string, ILog>();
        private static readonly ILogFactory _factory;
        private static readonly LogConfig _config;

        /// <summary>
        /// Gets the logging configuration.
        /// </summary>
        public static LogConfig Config
        {
            get { return _config; }
        }

        static LogManager()
        {
            _factory = new UnityLogFactory();
            _config = new LogConfig();
        }

        /// <summary>
        /// Gets the log with the name of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the log owner.</typeparam>
        /// <returns>The <see cref="ILog"/> with the name of the specified type.</returns>
        public static ILog GetLogger(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            return GetLogger(type.Name);
        }
        
        /// <summary>
        /// Gets the log with the name of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the log owner.</typeparam>
        /// <returns>The <see cref="ILog"/> with the name of the specified type.</returns>
        public static ILog GetLogger<T>()
        {
            return GetLogger(typeof(T));
        }

        /// <summary>
        /// Gets the log with the specified name.
        /// </summary>
        /// <param name="name">The name of the log.</param>
        /// <returns>The <see cref="ILog"/>  with the specified name.</returns>
        public static ILog GetLogger(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            ILog logger;
            if (!_loggers.TryGetValue(name, out logger))
            {
                logger = _factory.CreateLogger(name);
                _loggers.Add(name, logger);
            }

            return logger;
        }
    }
}
