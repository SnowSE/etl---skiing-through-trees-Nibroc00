using System;

namespace Skiing_Amongst_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            string Link = "TreeMap.txt";
            SkiSlope Zelda = new SkiSlope(Link);
            SkiTrip Ganon = Zelda.Ski(2, 2);
            Console.WriteLine(Ganon.report());
        }
    }
}
