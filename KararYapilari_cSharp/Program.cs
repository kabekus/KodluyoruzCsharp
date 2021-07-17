using System;

namespace KararYapilari_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            
            //If - Else If 
            if(time>=6 && time<11)
                Console.WriteLine("Good Morning...");
            else if(time>=11 && time<18)
                Console.WriteLine("Have a nice day...");
            else if(time>=18 && time<23)
                Console.WriteLine("Good evening...");
            else if(time>=00 && time<6)
               Console.WriteLine("Good Night...");    

            //Ternary - If 
            string day = time<=21 ? "The day goes on " : "Day is over";  
                   day = time>6 && time<=12 ? "Morning" 
                      : time>=18 && time<=23  ? "Evening" 
                      : time>0 ?"Night" 
                      : "Moon" ;
            Console.WriteLine(day);
        }
    }
}
