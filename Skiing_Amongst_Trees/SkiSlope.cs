using System;
using System.IO;


namespace Skiing_Amongst_Trees
{
    class SkiSlope {
        private string SlopeFile;
        private bool ValidFile = false;
        private int NumberOfLines;
        private int WidthOfLines;
        private int SkierLocationX = 1;
        private int SkierLocationY = 1;




        private bool verifyFile() {
            if (File.Exists(SlopeFile)) {
                int width;
                string line;
                int counter = 0;
                System.IO.StreamReader temp = new System.IO.StreamReader(SlopeFile);
                if ((line = temp.ReadLine()) != null) {  
                    width = line.Length;
                    counter++;
                }
                else {
                    Console.WriteLine("Invalid File. Set a new file path with SkiSlope.setSlopeFile()");
                    return false;
                }
                while ((line = temp.ReadLine()) != null)  {  
                    if (line.Length != width) {
                        Console.WriteLine("Invalid File. Set a new file path with SkiSlope.setSlopeFile()");
                        return false;
                    }
                    for (int i = 0; i < width; i++) {
                        if (line[i] != '#' && line[i] != '.') {
                            Console.WriteLine("Invalid File. Set a new file path with SkiSlope.setSlopeFile()");
                            return false;
                        }
                    }
                    counter++;
                }
                this.NumberOfLines = counter;
                this.WidthOfLines = width;
                return true;
            }
            Console.WriteLine("Invalid File. Set a new file path with SkiSlope.setSlopeFile()");
            return false;
        }

        public SkiTrip Ski(int x, int y) {
            SkiTrip Trip = new SkiTrip(ValidFile);
            if (ValidFile) {
                x = Math.Abs(x);
                y = Math.Abs(y);
                Trip.SlopeX = x;
                Trip.SlopeY = y;
                System.IO.StreamReader temp = new System.IO.StreamReader(SlopeFile);
                string line = temp.ReadLine();
                Trip.LinesSkied++;
                while (line != null) {
                    if (line[this.SkierLocationX - 1] == '#') {
                        Trip.Collisions++;
                        int[] Coordinates = new int[] {this.SkierLocationX, this.SkierLocationY};
                        Trip.CollisionLocations.Add(Coordinates);
                    }
                    for (int i = 0; i < y; i++) {
                        if (this.SkierLocationY == this.NumberOfLines) {
                            line = null;
                        }
                        else {
                            this.SkierLocationY++;
                            Trip.LinesSkied++;
                            line = temp.ReadLine();
                        }
                    }
                    for (int i = 0; i < x; i++) {
                        if (this.SkierLocationX == this.WidthOfLines) {
                            this.SkierLocationX = 1;

                        }
                        else {
                            this.SkierLocationX++;
                        }
                    }
                }
                return Trip;
            }
            else {
                return Trip;
            }
        }

        public string getSlopeFile() {
            return this.SlopeFile;
        }

        public void setSlopeFile(string input) {
            this.SlopeFile = input;
            this.verifyFile();
        }

        public int getNumberOfLines() {
            return NumberOfLines;
        }

        public int getWidthOfLines() {
            return WidthOfLines;
        }

        public bool getValidFile() {
            return ValidFile;
        }

        public SkiSlope(string input) {
            this.SlopeFile = input;
            this.ValidFile = this.verifyFile();
        }
    }
}