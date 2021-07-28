using System;

namespace Sınıflar_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct -> classlar gibi kullanılır.
            //class çağırma
            Diktortgen diktortgen = new Diktortgen();
            diktortgen.uzunKenar = 6;
            diktortgen.kisaKenar = 4;
            Console.WriteLine("Class ile Alan: " + diktortgen.AlanHesapla());

            //struct çağırma
            //Diktortgen_Struct diktortgen_struct = new Diktortgen_Struct(); bu şekilde de kullanılabilir.
            Diktortgen_Struct diktortgen_struct1;
            diktortgen_struct1.uzunKenar = 6;
            diktortgen_struct1.kisaKenar = 4;
            Console.WriteLine("Struct ile Çevre: " + diktortgen_struct1.CevreHesapla());

            Diktortgen_Struct diktortgen_struct2 = new Diktortgen_Struct(6,9);
            Console.WriteLine("Struct ile Çevre: " + diktortgen_struct2.CevreHesapla());

        }
    }

    class Diktortgen{
        public int kisaKenar, uzunKenar;
        public Diktortgen(){
         //classlarda parametresiz constructor tanımlanabilir!!
        }
        public long AlanHesapla(){
            return this.kisaKenar * this.uzunKenar;
        }

    }

    struct Diktortgen_Struct{
        public int kisaKenar, uzunKenar;
        public Diktortgen_Struct(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
            // structlarda parametresiz constructor tanımlanamaz!! 
        }
        public long CevreHesapla(){
           return 2*(this.kisaKenar + this.uzunKenar);
        }
    }
}
