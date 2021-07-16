using System;

namespace TurDonusum_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tür dönüşümleri : Implicit Conversion(Bilinçsiz) - Explicit Conversion(Bilinçli)

            //Implicit Conversion(Bilinçsiz)
            float a; int b = 25; a = b;
            Console.WriteLine(a);
            //Kapasite ksıtlamasına göre çeşitlendirilebilir

            //Explicit Conversion(Bilinli)
               
            int c; c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c);
            int p; p = int.Parse(Console.ReadLine());
            Console.WriteLine(p);
            long l = long.Parse(Console.ReadLine());
            Console.WriteLine(l);
            int xx=5;
            string yy = xx.ToString();
            Console.WriteLine("yy: "+ yy);




        }
    }
}
