using System;

namespace DateTimeveMath_cSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(36));

            //DateTime Format
            
            //Day
            Console.WriteLine(DateTime.Now.ToString("dd"));//24
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday
            
            //Month
            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Spr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Spring
            
            //Year
            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021


            //Math Metodu
            Console.WriteLine(Math.Abs(-25));//25
            Console.WriteLine(Math.Ceiling(22.3));//23
            Console.WriteLine(Math.Round(23.2));//23
            Console.WriteLine(Math.Round(23.7));//24
            Console.WriteLine(Math.Floor(23.7));//22
            Console.WriteLine(Math.Max(2,9));//9
            Console.WriteLine(Math.Min(2,9));//2
            Console.WriteLine(Math.Pow(4,2));//4 üzeri 2 işlemini yapar
            Console.WriteLine(Math.Sqrt(5));//Karekökünü alır
            
        }
    }
}
