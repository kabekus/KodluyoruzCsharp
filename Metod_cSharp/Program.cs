using System;

namespace Metod_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
             
             String sayi = "999";
             bool sonuc = int.TryParse(sayi,out int outSayi);
             if (sonuc)
             {
                Console.WriteLine("Başarılı " + outSayi);
             }else{ 
                 Console.WriteLine("Başarısız ");
             }

             //Ayrı bir class tanımladıktan sonra onu kullanabilmek için o class'ın instance ını oluşturmalıyız.
            
            Metodlar instance = new Metodlar();
            instance.Topla(9,5,out int sonuc2);
            Console.Write(sonuc2);

            //Method Overloading - Aşırı Yükleme
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Hello","World");

        }
        class Metodlar
        {
            public void Topla(int a, int b, out int toplam){
                toplam = a+ b;
            }

            public void EkranaYazdir(string veri){
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri){
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(string veri1 , string veri2){
                Console.WriteLine(veri1 + veri2);
            }

        }
    }
}
