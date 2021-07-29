using System;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
           FileLogger fileLogger=new FileLogger();
           fileLogger.WriteLog();

           DataBaseLogger databaseLogger=new DataBaseLogger();
           databaseLogger.WriteLog();

           SmsLogger smsLogger=new SmsLogger();
           smsLogger.WriteLog();

           LogManager logManager = new LogManager(new FileLogger());
           logManager.WriteLog();

        }
    }
}
