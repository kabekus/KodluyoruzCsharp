using System;

namespace HelloWorld_cSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("First Name:");
            string firstName= Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName= Console.ReadLine();
            Console.WriteLine("Merhaba " + firstName + " " + lastName);
        }
    }
}
