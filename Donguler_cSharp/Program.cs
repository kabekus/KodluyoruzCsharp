using System;

namespace Donguler_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int tekToplam=0 ,ciftToplam=0;
            for(int i=0;i<=100;i++){
                if (i%2==0)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek Toplam: "+tekToplam);
            Console.WriteLine("Çift Toplam: "+ciftToplam);

            //break - continue
            for(int a=0;a<=10;a++){
                if (a==3)
                    break;
                    Console.Write("A:"+a);
                    Console.Write(" ");
                    //output-> A:0 A:1 A:2
            }

            for(int b=0;b<=10;b++){
                if (b==3)
                    continue;
                    Console.Write("B:"+b);
                    Console.Write(" ");
                    //output-> B:0 B:1 B:2 B:4 B:5 B:6 B:7 B:8 B:9 B:10
            }

        }
    }
}
