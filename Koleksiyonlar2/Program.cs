using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayList liste = new ArrayList();
            liste.Add("Gül");
            liste.Add(2);
            liste.Add(true);
            liste.Add('L');
            //liste içine erişim
            Console.WriteLine(liste[3]);
            foreach (var item in liste){
               Console.WriteLine(item);
            }

            //AddRange -> collection türünde veri eklmeye yarar. öreneğin dizi ve list gibi
            string[] renkler = {"Mor","Mavi","Gri"};
            List<int> sayilar = new List<int>(){1,6,12,3,9,7,15,5,25};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var yeni in liste){
                Console.WriteLine(yeni);
            }

            //sort -> sıralama için kullanılır fakat ArrayList içinde sadece tek tür veri olmalı.

            // Binary Search -> kullanımı için önce kendi içinde sıralanır.
            //Console.WriteLine(liste.BinarySearch("Bulmak istediğimiz eleman"));

            //Reverse -> sıralı bir dizi veya arraylisti ters çevirir
            // liste.Clear(); tüm listeyi temizler.
        }
    }
}
