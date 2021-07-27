using System;

namespace Metodlar2_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif Metodlar - Öz Yinelemeli Metodlar : Kendi kendini çağıran metodlardır. Üs alma işleminde kullanılır.

            int result = 1;
            for(int  i=1;i<5;i++){
                result= result * 3;
            }
            Console.WriteLine(result);

            Islemler instance=new();
            Console.WriteLine(instance.Expo(6,1));

            // Extension Metodlar
            string ifade = "Kodluyoruz patika.dev Eğitimleri";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(sonuc);
            if(sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
        }
    }
    public class Islemler 
    {
        public int Expo(int sayi, int üs){
           int islem = üs<2?sayi: Expo(sayi,üs-1)*sayi;
           return islem;
        }
    }
    public static class Extension
    { //Extension class ve metodlar static olmalı.
      public static bool CheckSpace(this string param){
        return param.Contains(" ");
        //Boşluk içeriyor mu diye kontrol eder.
      }
      public static string RemoveWhiteSpaces(this string param){
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
        //boşlukları kaldırma
        //return string.Join("*", dizi); -> boşluk olan yerlere * koyma işlemi yapıldı
      }

      public static string MakeUpperCase(this string param){
          return param.ToUpper();
          //harfleri büyüt
      }
      public static string MakeLowerCase(this string param){
          return param.ToLower();
          //harfleri küçült
      }


    }
}
