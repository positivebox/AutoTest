using log4net;
using log4net.Config;

namespace Framework
{
    public static class Logger
    {
        private static readonly ILog log =
            LogManager.GetLogger(typeof(Logger));

        public static void Info(string message)
        {
            XmlConfigurator.Configure();
            log.Info(message);
        }

        public static void Error(string message)
        {
            XmlConfigurator.Configure();
            log.Error(message);
        }
    }
}
