using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Accessibility { get; private set; }
        public int LandedTime { get; set; }
        public int MoveType { get; set; }
        public bool isLanded { get; set; }
        public bool isCurrCoor { get; set; }

        public Coordinate() {}

        public Coordinate(int x, int y, int accessibility)
        {
            this.X = x;
            this.Y = y;
            this.Accessibility = accessibility;
            isLanded = false;
            isCurrCoor = false;
        }

        public void Land()
        {
            isLanded = true;
            isCurrCoor = true;
        }

        public void Leave()
        {
            isCurrCoor = false;
        }
    }

}
