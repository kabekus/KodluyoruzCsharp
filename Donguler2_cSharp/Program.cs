using System;

namespace Donguler2_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //while

            //1den başlayarak dışarıdan girilen sayıya kadar ort. alma  
            // Console.WriteLine("Sayı Girin:");
            // int sayi=int.Parse(Console.ReadLine()),toplam=0, sayac=1;
            // while (sayac<=sayi)
            // {
            //     toplam+=sayac;
            //     sayac++;
            // }
            // Console.WriteLine(toplam/sayi);

            //a'dan z'ye tüm harfler

            // char character='a';
            // while (character<'z')
            // {
            //     Console.WriteLine(character);
            //     character++;
            // }

            //foreach
            string[] cars={"Ford","Toyota","Nissan","BMW"};
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
