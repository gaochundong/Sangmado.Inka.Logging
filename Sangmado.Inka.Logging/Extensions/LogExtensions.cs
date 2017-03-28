using System;

namespace Sangmado.Inka.Logging
{
    public static class LogExtensions
    {
        public static void DebugOrWarn(this ILog log, double timeCostBySeconds, double timeThresholdBySeconds, object obj)
        {
            if (timeCostBySeconds < timeThresholdBySeconds)
                log.Debug(obj);
            else
                log.Warn(obj);
        }

        public static void DebugOrWarn(this ILog log, double timeCostBySeconds, double timeThresholdBySeconds, object obj, Exception exception)
        {
            if (timeCostBySeconds < timeThresholdBySeconds)
                log.Debug(obj, exception);
            else
                log.Warn(obj, exception);
        }

        public static void DebugOrWarn(this ILog log, double timeCostBySeconds, double timeThresholdBySeconds, LogOutputProvider messageProvider)
        {
            if (timeCostBySeconds < timeThresholdBySeconds)
                log.Debug(messageProvider);
            else
                log.Warn(messageProvider);
        }

        public static void DebugFormatOrWarnFormat(this ILog log, double timeCostBySeconds, double timeThresholdBySeconds, IFormatProvider formatProvider, string format, params object[] args)
        {
            if (timeCostBySeconds < timeThresholdBySeconds)
                log.DebugFormat(formatProvider, format, args);
            else
                log.WarnFormat(formatProvider, format, args);
        }

        public static void DebugFormatOrWarnFormat(this ILog log, double timeCostBySeconds, double timeThresholdBySeconds, string format, params object[] args)
        {
            if (timeCostBySeconds < timeThresholdBySeconds)
                log.DebugFormat(format, args);
            else
                log.WarnFormat(format, args);
        }
    }
}
