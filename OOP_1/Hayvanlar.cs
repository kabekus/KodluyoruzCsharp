using System;
namespace OOP_1
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Adaptasyon Hayvanlara Özgüdür");
        }
    }

    public class Surungen:Hayvanlar{
        public void Surunme(){
            Console.WriteLine("Sürüngenler Sürünerek Hareket Eder");
        }
    }
     public class Kuslar:Hayvanlar{

         public Kuslar(){
             base.Adaptasyon(); // Özellikle çağırmadan kuslar ı çağırdığımız her aman çalışır.
         }
        public void Ucma(){
            Console.WriteLine("Kuşlar Uçarak Hareket Eder");
        }
    }
}