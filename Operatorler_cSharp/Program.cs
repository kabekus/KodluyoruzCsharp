using System;

namespace Operatorler_cSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Atama & İşlemli Atama
            int x = 3, y=6;
            y = y+2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            x *= 4;
            Console.WriteLine(x);

            //Mantıksal operatörler ||,&&,!

            bool isSuccess =true;
            bool isCompleted = false;
            if(isSuccess && isCompleted){
                Console.WriteLine("Perfect!");
            }
            if(isSuccess || isCompleted){
                Console.WriteLine("Great!");
            }
            if(isSuccess && !isCompleted){
                Console.WriteLine("Fine!");
            }

            // İlişkisel Operatörler <, >, <=, >=, ==, =!
            int a=3, b=6;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler +, -, *, /
            int sayi1=9, sayi2=4, islem=sayi1/sayi2;
            Console.WriteLine(islem);
            islem=sayi1*sayi2;
            Console.WriteLine(islem);
            islem=sayi1+sayi2;
            Console.WriteLine(islem);
            islem=sayi1-sayi2;
            Console.WriteLine(islem);
            islem = sayi1 % sayi2; //mod alma yani bölümden kalan
            Console.WriteLine(islem);


        }
    }
}
