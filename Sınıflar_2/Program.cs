using System;

namespace Sınıflar_2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Kurucu / Yapıcı metodlar (constructor) -> bir sınıfın nesnesi oluşturulduğunda arka planda otomatik çalışan metodlardır.
           // Kurucu metodların isimleri sınıf isimleri ile mutlaka anyı olmalı, erişim belirleyicileri mutlaka public olmalı
           // Geri dönüş tipleri olmalı. Parametre almayabilir alabilir.


            Calisan calisan1 = new Calisan("Ayşe","Güneş",12398764,"Satın Alma");
            calisan1.CalisanBilgileri(); //console'a yazdırma.
            Calisan calisan2= new Calisan("Ali","Toprak"); 
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan{
        public string Ad, Soyad, Departman;
        public int No;

        public Calisan(string ad, string soyad, int no, string departman){
        this.Ad = ad; // this bu classı belirtir. Ad classta tanımlanan değişken, ad ise parametre olarak gelen değer. istediğimizi verebiliriz.
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
        }
        public Calisan(string ad, string soyad){ //constructorlarda aşırı yükleme (over loading)
        this.Ad = ad; 
        this.Soyad = soyad;
        }

        public void CalisanBilgileri(){
            Console.WriteLine("Ad: {0}", Ad);
            Console.WriteLine("Soyad: {0}", Soyad);
            Console.WriteLine("Numara: {0}", No);
            Console.WriteLine("Departman: {0}", Departman);
        }
    }
}
