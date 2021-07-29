using System;

namespace OOP_2
{
    public class SmsLogger : Ilogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms'e log yazar");
        }
    }
}