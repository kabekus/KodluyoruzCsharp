using System;

namespace Diziler_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dzi tanımlama
            string[] colors = new string[5]; //boyutu 5 olan string bir dizi
            string[] animals = {"Kedi","Köpek","Kuş","Panda"};
            int[] array;
            array = new int[5];

            //Değer atama ve Erişim
            colors[0]= "Purple"; //Değer atama
            Console.WriteLine(animals[1]); //Erişim

            //Döngülerle dizi kullanımı

            //girilen n tane sayının ortalması
            Console.Write("Dizi uzunluğunu belirleyin: ");
            int uzunluk = int.Parse(Console.ReadLine());
            int[] dizi = new int[uzunluk];

         for (int i = 0; i < uzunluk; i++)
         {
             Console.WriteLine("{0}. sayıyı girin: ", i+1);
             dizi[i] = int.Parse(Console.ReadLine());
         }

         int toplam =0;
         foreach (var value in dizi)
         {
             toplam += value;
         }
          Console.WriteLine("Ortalama: " + toplam/uzunluk);
        }
    }
}
