using System;

namespace OOP_2
{
    public class FileLogger : Ilogger
    {
        public void WriteLog()
        {
           Console.WriteLine("Dosyaya Log yazar.");
        }
    }
}