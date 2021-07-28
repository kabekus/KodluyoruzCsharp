using System;

namespace Sınıflar_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum -> Sıralama anlamına gelir.

            Console.WriteLine(Gunler.perşembe);
            Console.WriteLine((int)Gunler.perşembe); // numaric değerini görmek için dönüşüm yapıldı.

            
            int sicaklik = 34 ;
            if(sicaklik<=(int)HavaDurumu.soguk)
                    Console.WriteLine("Çok Soğuk"); 
            else if(sicaklik>=(int)HavaDurumu.cokSıcak)
                    Console.WriteLine("Çok Sıcak");
            else if(sicaklik>=(int)HavaDurumu.sıcak)
                    Console.WriteLine("Sıcak");
            else if(sicaklik>=(int)HavaDurumu.normal && sicaklik<=(int)HavaDurumu.sıcak)
                    Console.WriteLine("İdeal");
            else
               Console.WriteLine("Lütfen bir sıcaklık girin!");

        }
    }
    enum Gunler{
        //Herne kadar strik yazıyor gibi görünsek te numeric değerini tutar.
        Pazar,
        Pazartesi,
        //Pazartesi = 50 diye tanımlama yaparsak salı 51 olur ve artarak devam eder.
        Salı,
        Çarşamba,
        perşembe,
        Cuma,
        Cumartesi
    }

    enum HavaDurumu{
        soguk = 10,
        normal = 20,
        sıcak = 30,
        cokSıcak = 35

    }
}
 