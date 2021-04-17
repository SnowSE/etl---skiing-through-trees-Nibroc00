using System;
using System.Collections.Generic;

namespace Skiing_Amongst_Trees
{
    class SkiTrip {
        public int Collisions = 0;
        public List<int[]> CollisionLocations = new List<int[]>();
        public int LinesSkied;
        public int SlopeX;
        public int SlopeY;

        public string report() {
            string Returned = "------------------------------------------------------------------------------------------------------";
            Returned += "\nSki Trip: \n    Lines skied: " + LinesSkied + " \n    Trees Hit: " + Collisions + " \n        Locations: \n";
            foreach (int[] Coordinate in CollisionLocations) {
                Returned += "            (" + Coordinate[0] + ", " + Coordinate[1] + ") \n";
            }
            Returned += "    Slope: " + SlopeX + " Right " + SlopeY + " Down \n";
            Returned += "------------------------------------------------------------------------------------------------------";
            return Returned;
        }
    }
}