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
            Console.WriteLine($"Номер первого элемента, нарущающего очередность( 0 означает, что очередность не нарушена): {alternate}");
            Console.ReadLine();
        }
    }
}
