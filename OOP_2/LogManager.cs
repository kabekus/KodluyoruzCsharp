using System;

namespace OOP_2
{
    public class LogManager: Ilogger{
        public Ilogger _logger;
        public LogManager(Ilogger logger){
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}