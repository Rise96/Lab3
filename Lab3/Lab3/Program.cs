using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massiveOfNumber = {1,2,3,4,5,6,7,8,9,10 };
            AlternationFinder newFinder = new AlternationFinder();
            String alternate = newFinder.IsItAlternate(massiveOfNumber);
            Console.WriteLine($"{alternate}");
            Console.ReadLine();
        }
    }
}
