using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiList= new List<int>();
            sayiList.Add(60);
            sayiList.Add(30);
            sayiList.Add(42);
            sayiList.Add(5);
            sayiList.Add(12);
            sayiList.Add(9);
            sayiList.Add(76);
            sayiList.Add(22);
            sayiList.Add(4);

            List<string> renkList= new List<string>();
            renkList.Add("Pembe");
            renkList.Add("Mavi");
            renkList.Add("Mor");
            renkList.Add("Siyah");
            renkList.Add("Sarı");
            renkList.Add("Kırmızı");
            renkList.Add("Turuncu");
            renkList.Add("Yeşil");
            
            //Count liste uzunluğunu verir
            Console.WriteLine(sayiList.Count);
            Console.WriteLine(renkList.Count);

            //Foreach ve list.foreach ile elemanlara erişim sağlarız
            foreach (var sayi in sayiList)
                    Console.WriteLine(sayi);
            Console.WriteLine("***"); 
            foreach (var renk in renkList)
                    Console.WriteLine(renk);  
            Console.WriteLine("***"); 
            sayiList.ForEach(sayi => Console.WriteLine(sayi));
            Console.WriteLine("***"); 
            renkList.ForEach(renk => Console.WriteLine(renk));

            // Remove listeden eleman çıkarmaya yarar
             Console.WriteLine("***"); 
            sayiList.Remove(4);
            renkList.Remove("Kırmızı");
            //RemoveAt ise index no ile eleman çıkarmaya yarar
             Console.WriteLine("***"); 
            sayiList.RemoveAt(6);
            renkList.RemoveAt(3);
            

            // Contains ile liste içinde arama yaparız
             Console.WriteLine("***"); 
            if (renkList.Contains("Mor")){
                Console.WriteLine("Mor bu listede!!");
            }else{
                Console.WriteLine("Mor bu listede yok!!");
            }
 
            //Diziyi Listeye Çevirme!!!! 
            string[] hayvanlar = {"Panda", "Aslan", "Zürafa"};
            List<string> hayvanlist = new List<string>(hayvanlar);
            hayvanlist.Clear(); //Liste temizleme!!!



             //List içerisinde nesne tutmak (class oluşturuldu)
            List <Kullanicilar> kullanicilarListesi=new List<Kullanicilar>();

            Kullanicilar kullanici1=new Kullanicilar(); //kullanıcılar listesinden kullanıcı 1 türetildi
            kullanici1.Isim="Ayşe";
            kullanici1.SoyIsim="Yılmaz";
            kullanici1.Yas=26;

            Kullanicilar kullanici2=new Kullanicilar(); //kullanıcılar listesinden kullanıcı 2 türetildi
            kullanici2.Isim="Özcan";
            kullanici2.SoyIsim="Çalışkan";
            kullanici2.Yas=34;

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);

            List<Kullanicilar> yeniList = new List<Kullanicilar>();
            yeniList.Add(new Kullanicilar(){ //Kullanıcılar listesine direkt özellik eklendi
                Isim="Kabe",
                SoyIsim="Kuş",
                Yas=23
            });

            foreach (var kullanici in kullanicilarListesi)
            {
                Console.WriteLine(kullanici.Isim);
                Console.WriteLine(kullanici.SoyIsim);
                Console.WriteLine(kullanici.Yas);
            }


        }
    }
    public class Kullanicilar{
        string isim, soyIsim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
