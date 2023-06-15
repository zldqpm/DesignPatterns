using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    using System;

    // 第三方日志记录库的接口
    public interface ILogger
    {
        void Log(string message);
    }

    // 第三方日志记录库的实现
    public class ThirdPartyLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[ThirdPartyLogger] {message}");
        }
    }

    // 系统内部的日志记录接口
    public interface ILoggingService
    {
        void LogInfo(string message);
        void LogError(string message);
    }

    // 适配器类，将第三方日志记录库适配为系统内部的日志记录接口
    public class LoggerAdapter : ILoggingService
    {
        private readonly ILogger logger;

        public LoggerAdapter(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogInfo(string message)
        {
            logger.Log($"[INFO] {message}");
        }

        public void LogError(string message)
        {
            logger.Log($"[ERROR] {message}");
        }
    }
}
