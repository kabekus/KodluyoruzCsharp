using System;

namespace Sınıflar_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Çaışsan Sayısı: {0}", Calisan.CalisanSayisi);
             //static sınıf olmadığı için new ledik
            Calisan calisan = new Calisan("Ayşe","Veli","İnsan Kaynakları");
            Console.WriteLine("Çaışsan Sayısı: {0}", Calisan.CalisanSayisi);

            //static bir sınıf new yapılmadan çağırılabilir.
            Console.WriteLine("Toplama: "+Islemler.Topla(35,659));
            Console.WriteLine("Çıkarma: "+Islemler.Cikar(186,98));

            
          //static olmayan sınıfların içerisinde herhangi bir metod property tanımlayamz ve kullanamayız.


        }
    }
    class Calisan{
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; }

        private string isim, soyisim, departman;
        static Calisan(){ //static constructor ların erişim belirteçleri ve geri dönüş tipleri yoktur
           calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi ++;
        }
    }
    static class Islemler{
        public static long Topla (int sayi1, int sayi2){
            return sayi1+sayi2;
        }
         public static long Cikar (int sayi1, int sayi2){
            return sayi1-sayi2;
        }
    }
}
