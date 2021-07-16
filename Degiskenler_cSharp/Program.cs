using System;

namespace Degiskenler_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string giris="Değişken Çalışmaları";
            Console.WriteLine(giris);
            
             // Değişkenler kü.ük-büyük harf duyarlıdır. degisken != Degisken.
            string degisken=" "; 
            string Degisken=" "; 

            byte b = 5;   //1 byte
            sbyte c = 5;  //1 byte

            short s = 5;  //2 byte
            ushort us= 5; //2 byte
            
            int i = 2;    //4 byte
            Int16 i16 =2; //2 byte
            Int32 i32 =2; //4 byte
            Int64 i64 =2; //8 byte

            uint ui =2;   //4 byte
            long ln =2; //8 byte
            ulong ul =2; //8 byte

            float f=5; //4 byte
            double d =4.16; //8 byte
            decimal de=5; //16 byte

            char ch='2'; //2 byte
            string str ="Hello World!"; //sınırsız

            bool bl= true; // true or false

            DateTime dt= DateTime.Now; // o anın tarih ve saati

            object o= "x"; // tüm değişken türlerini alır 

            //string ifadeler 
            string firstName ="Kabe" , lastName="KUŞ"; 
            string student= firstName + " " + lastName; // output -> Kabe KUŞ 

            //integer ifadeler 
            int birthYear = 1998;
            int currentYear = 2021;
            int age= currentYear - birthYear; // output -> 2021-1998 = 23 

            //Değişken Dönüşüm:
            string str20 ="20";
            int int20 = 20;
            string yenistr = str20 + int20.ToString(); //int20 olan değer string türüne dönüştürüldü.
            int yeniint = int20 + Convert.ToInt32(str20); // str20 olan değer integer türüne dönüştürüldü.

            string date = DateTime.Now.ToString("dd.MM.yyyy");
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(date + " - " + hour); // output -> 15.07.2021 - 05:30

            
        }
    }
}
