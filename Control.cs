using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTour
{
    abstract class Control : IControls
    {

        // Change X coordinate based on the type of move
        public int MovingX(int move, int x)
        {
            if (move == 0 || move == 7) { x += 2; }
            else if (move == 1 || move == 6) { x += 1; }
            else if (move == 2 || move == 5) { x -= 1; }
            else if (move == 3 || move == 4) { x -= 2; }
            return x;
        }

        // Change Y coordinate based on the type of move
        public int MovingY(int move, int y)
        {
            if (move == 0 || move == 3) { y -= 1; }
            else if (move == 1 || move == 2) { y -= 2; }
            else if (move == 4 || move == 7) { y += 1; }
            else if (move == 5 || move == 6) { y += 2; }
            return y;
        }

        public abstract bool NonIntelligentPlay(Coordinate currCoordinate, 
            Coordinate[,] coordinates, Random r);
        public abstract bool HeuristicsPlay(Coordinate currCoordinate, 
            Coordinate[,] coordinates, Random r);
    }
}
