using System;

namespace Metod_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2, b=9; 
            Console.WriteLine(a+b);

            int result = Gather(a,b);
            Console.WriteLine(result);

            Operation example = new Operation();
            example.WriteToScreen(Convert.ToString(result));
            
            int result2 = example.IncreaseAndCollect(ref a , ref b);
            example.WriteToScreen(Convert.ToString(result2));
            example.WriteToScreen(Convert.ToString(a+b));

        }
        static int Gather(int x, int y){
            return x+y;
        }
    }
    class Operation
    {
        public void WriteToScreen(string value){
            Console.WriteLine(value);
        }

        public int IncreaseAndCollect(ref int x, ref int y){
            x += 1;
            y += 1;
            return x+y;

        } 

    }
}
