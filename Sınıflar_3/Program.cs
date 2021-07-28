using System;

namespace Sınıflar_3
{
    class Program
    {
        static void Main(string[] args)
        {
           //Encapsulation -> Kapsülleme bir nesnenin bazı özelliklerini işlevlerini metodlarını diğer classlardan diğer nesnelerden korumak anlamına gelir


            Ogrenci ogrenci1 = new Ogrenci("Ayşe", "Arda", 359,2);
            ogrenci1.OgrenciBilgiGetir();

            Ogrenci ogrenci2 = new Ogrenci("Osman", "Sıkı", 115,1);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgiGetir();

            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.Isim="Lale";
            ogrenci3.Soyisim="Kal";
            ogrenci3.OgrenciNo=639;
            ogrenci3.Sinif=3;
            ogrenci3.SinifAtla();
            ogrenci3.OgrenciBilgiGetir();

        }
    }

    class Ogrenci{
        private string isim, soyisim;
        private int ogrenciNo, sinif;
        public string Isim { get => isim; set => isim = value; }

        

        // public string Isim {
        //     get {return isim ;} 
        //     set {isim = value ;}
        // }  diğerleri ile aynı şey
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { get => sinif; 
        set {
            if(value < 1){
                Console.WriteLine("Sınıf en az 1 olmalı!!");
                sinif = 1;
            }
            else
                sinif = value;} 
        }

        public Ogrenci(){}

        public Ogrenci(string ısim, string soyisim, int ogrenciNo , int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgiGetir(){
            Console.WriteLine("Ad   : {0}", this.Isim);
            Console.WriteLine("Soyad: {0}", this.Soyisim);
            Console.WriteLine("No   : {0}", this.OgrenciNo);
            Console.WriteLine("Sınıf: {0}", this.Sinif);
        }
        public void SinifAtla(){
        this.Sinif = this.Sinif + 1;
        }
         public void SinifDusur(){
        this.Sinif = this.Sinif - 1;
        }
    }
}
