using System;

namespace Diziler2_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort-Sıralama
            int [] numberList = {50,12,6,94,30,1,20};
            foreach (var num in numberList)
                Console.Write("Sırasız" + num);

            Array.Sort(numberList); //başka bir diziye atamamız gerekmez
            foreach (var num in numberList)
                Console.Write("Sıralı" + num);

            //Clear-Verdiğimiz indexten başlayarak verdiğimiz eleman sayısı kadar değeri 0'lar.
            Array.Clear(numberList,2,3);
            foreach (var num in numberList)
                Console.Write("Sırasız" + num);

            //Reverse
            Array.Reverse(numberList);
            foreach (var num in numberList)
                Console.Write("Sırasız" + num);

            //IndexOf
            Console.WriteLine(Array.IndexOf(numberList,30));

            //Resize
            Array.Resize<int>(ref numberList,8);
            numberList[7]=100;
            foreach (var num in numberList)
                Console.Write("Sırasız" + num);
        } 
    }
}
