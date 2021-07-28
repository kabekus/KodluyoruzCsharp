using System;

namespace Sınıflar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodlarda geriye bir şey döndürmüyorsak void anahtar kelimesi girilir

            //Erişim Belirteçleri
            // * Public Her yerden erişim
            // * Private Sade tanımlandığı sınıf içerisinden erişebilir
            // * Internal  Sadece bulunduğu proje (.csproj) içerisinden erişim
            // * Protected Sadece tanımlandığı sınıfta ve o sınıftan kalıtım alan diğer sınıflardan erişim 

            Calisan calisan1 = new Calisan();
            calisan1.Ad="Deniz";
            calisan1.Soyad="Bilgili";
            calisan1.No=192837;
            calisan1.Departman="Bilgi İşlem";

           calisan1.CalisanBilgileri();
        }
    }

    class Calisan{
        public string Ad, Soyad, Departman;
        public int No;

        public void CalisanBilgileri(){
            Console.WriteLine("Ad: {0}", Ad);
            Console.WriteLine("Soyad: {0}", Soyad);
            Console.WriteLine("Numara: {0}", No);
            Console.WriteLine("Departman: {0}", Departman);
        }

    }
}
