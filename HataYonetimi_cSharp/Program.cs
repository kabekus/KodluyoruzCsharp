using System;

namespace HataYonetimi_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
             {
                //Hataya sebep olabilecek kodalar -try- içine yazılır
                Console.WriteLine("Sayı Giriniz: ");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen Sayı: " + sayi);
                 
             }
             catch(Exception ex){
                //Hatayı yakar ve ne hatası olduğnu döndürür
                Console.WriteLine("Hata: " + ex.Message.ToString());

             }
             finally //Zorunlu değil!!!
             {
                //Hatalı olsun veya olmasın çalışmasını istediğimiz kısım
                Console.WriteLine("İşlem Tamamlandı!");
                 
             }

             try{
                int a = int.Parse(null);
                int b = int.Parse("test");
                int c = int.Parse("200000000000");
             }
             catch (ArgumentException ex){
                 
                Console.WriteLine("Boş Değer!" + ex);
             }
              catch (FormatException ex){
                 
                Console.WriteLine("Veri Tipi Hatası!" + ex);
             }
              catch (OverflowException ex){
                 
                Console.WriteLine("Değer Aşımı!" + ex);
             }
             finally{
                 Console.WriteLine("İşlemler Tamam!");
             }
        }
    }
}
