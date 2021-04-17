using System;

namespace Skiing_Amongst_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            string Link = "TreeMap.txt";
            SkiSlope Zelda = new SkiSlope(Link);
            // Console.WriteLine(Zelda.getValidFile());
            // Console.WriteLine(Zelda.getNumberOfLines());
            // Console.WriteLine(Zelda.getWidthOfLines());
            SkiTrip Ganon = Zelda.Ski(11, 11);
            Console.WriteLine(Ganon.report());
        }
    }
}
