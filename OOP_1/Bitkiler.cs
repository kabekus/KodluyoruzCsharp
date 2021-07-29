using System;
namespace OOP_1
{
    public class Bitkiler : Canlilar
    {
         public void Fotosentez(){
            Console.WriteLine("Fotosentez Bitkilere Özeldir");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler uyaranlara tepki verir");
        }
    }
    public class Tohumlu:Bitkiler{
        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır");
        }

    }
    public class Tohumsuz:Bitkiler{
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz Bitkiler Sporla Çoğalır");
        }

    }
}