using System;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // OOP 3 Ana prensipten oluşur -> *Encapsulation *Polimorphizim *Inheritence
            //Inheritence (Kalıtım) -> Alt sınıfın üst sınıftan kalıtım alarak üst sınıfın bazı özelliklerini kendisinin kullanmaası denebilir.
            //sealed  anahtar kelimesini kullandığımız class hiçbir şekilde kalıtım veremez.

            Tohumlu tohumluBitki = new Tohumlu();
            tohumluBitki.Beslenme();
            tohumluBitki.Bosaltim();
            tohumluBitki.Fotosentez();
            tohumluBitki.Solunum();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("********");

            Kuslar serce = new Kuslar();
            // serce.Adaptasyon(); base ile kuslar içerisinde çağırıldı
            serce.Beslenme();
            serce.Bosaltim();
            serce.Ucma();
        }
    }
}
