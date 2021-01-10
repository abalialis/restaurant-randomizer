using System;

namespace thing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You should eat at...");
            
            
            Random rd = new Random();
            string[] whereToEatAt = { "Whataburger", "Chic Fil Lay", "Taco Bell", "Panda Express" };
            Console.WriteLine(whereToEatAt[rd.Next(0, 3)]);

            Console.WriteLine(" ");
            Console.WriteLine("See you there!");
            Console.ReadLine();
        }
    }
}
