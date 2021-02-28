using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTour
{
    interface IControls
    {
        bool HeuristicsPlay(Coordinate currCoordinate, Coordinate[,] coordinates, Random r);
        bool NonIntelligentPlay(Coordinate currCoordinate, Coordinate[,] coordinates, Random r);
    }
}
