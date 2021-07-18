using System;

namespace StringMetod_cSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string degisken = "Dersimiz C#, Hoşgeldiniz";
            //length
            Console.WriteLine(degisken.Length);

            //Concat - iki stringi birleştirir
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            //Compare, CompareTo - iki string karşılaştırması
            string degisken2 = "Dersimiz C#, Hoşgeldiniz. Bu bir karşılaştrıma";
            Console.WriteLine(degisken.CompareTo(degisken2)); 
            //uzunluk için degisken (== , > , < ) degisken2 -> 0, 1, -1 döndürür 
            Console.WriteLine(String.Compare(degisken,degisken2,true)); 
            Console.WriteLine(String.Compare(degisken,degisken2,false));
            //compareTo ile aynı işlemi yapar ve sonuc aynı.

            Console.WriteLine(degisken.Contains(degisken2)); //
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            // Bitişini kontrol eder. Eğer içeriyorsa true içermiyorsa false 
            Console.WriteLine(degisken.StartsWith("Merhaba"));
            // Sonunu kontrol eder. Eğer içeriyorsa true içermiyorsa false 
            Console.WriteLine(degisken.IndexOf("C#"));
            //içeriği arar ve bulduğu anda C'nni indexini verir. Birşey bulamazsa -1
            Console.WriteLine(degisken.Insert(0,"Merhaba "));
            //Belirtilen index nosu da dahil verilen stringi ekler.
            Console.WriteLine(degisken.LastIndexOf("i")); 
            //verilen karakter birden fazla da olsa en soncusunun indexini verir
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            // degisken2 nin uzunluğunu 30'a tamamlayacak kadar soluna boşluk ekler
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            // degisken2 nin uzunluğunu 30'a tamamlayacak kadar soluna * ekler
            Console.WriteLine(degisken.PadLeft(30,'*') + degisken2);
            // degisken in uzunluğunu 30'a tamamlayacak kadar soluna * ekler
            Console.WriteLine(degisken.Remove(5));
            //degisken içini 5. indexten başlayarak siler
            Console.WriteLine(degisken.Remove(3,9));
            //içeriğini 3. indexten sonra 9 karakter siler
            Console.WriteLine(degisken.Replace("Hoşgeldiniz","101"));
            //istediğimiz kısmı istediğimiz kelime ya da karakter ile değiştiriyoruz.
            Console.WriteLine(degisken.Substring(4));
            //4. indexten başlayıp cümlenin sonuna kadar getirir
            Console.WriteLine(degisken.Substring(6,9));
            //6. indexten başlayarak 9a kadar getirdi.

            
        }
    }
}
