using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeadReckoned.ULog
{
    public class LogConfig
    {
        private bool[] _levelState;

        internal LogConfig()
        {
            _levelState = new bool[Enum.GetValues(typeof(LogLevel)).Length];

            // Set all level states to true by default
            for (int i = 0; i < _levelState.Length; ++i)
            {
                _levelState[i] = true;
            }
        }

        /// <summary>
        /// Sets the enabled state for a <see cref="LogLevel"/>.
        /// </summary>
        /// <param name="level">The logging level to set.</param>
        /// <param name="state">The enabled state of the level.</param>
        /// <returns>A reference to this <see cref="LogConfig"/></returns>
        public LogConfig SetLevel(LogLevel level, bool state)
        {
            _levelState[(int)level] = state;
            return this;
        }

        /// <summary>
        /// Determines if a specific <see cref="LogLevel"/> is enabled.
        /// </summary>
        /// <param name="level">The logging level to test.</param>
        /// <returns>A Boolean indicating if the supplied level is enabled.</returns>
        public bool IsLogLevelEnabled(LogLevel level)
        {
            return _levelState[(int)level];
        }
    }
}
