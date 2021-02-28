using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    partial class ControlMethods : Control
    {
        public override bool NonIntelligentPlay(Coordinate currCoordinate, 
            Coordinate[,] coordinates, Random r)
        {
            int count = 0;
            int move, newX, newY;

            Coordinate nextCoordinate = null;

            // Using random to generate random move, and pick whatever possible move comes up first;
            do
            {
                move = r.Next(8);
                newX = base.MovingX(move, currCoordinate.X);
                newY = base.MovingY(move, currCoordinate.Y);

                if  (((newX >= 0 && newX <= 7)
                    && (newY >= 0 && newY <= 7))
                    && !coordinates[newX, newY].isLanded)
                { 
                    nextCoordinate = coordinates[newX, newY];
                    nextCoordinate.MoveType = move;
                    break;
                }

                count++;
            } while (count < 15);

            // Going through all types of move and see if there will be any possible 
            // move if the previous code block can't not genarate any possible move

            if (nextCoordinate == null)
            {
                for (int i = 0; i < 8; i++)
                {
                    newX = base.MovingX(i, currCoordinate.X);
                    newY = base.MovingY(i, currCoordinate.Y);

                    if (((newX >= 0 && newX <= 7)
                        && (newY >= 0 && newY <= 7))
                        && !coordinates[newX, newY].isLanded)
                    {
                        nextCoordinate = coordinates[newX, newY];
                        nextCoordinate.MoveType = move;
                        break;
                    }
                }

                if (nextCoordinate == null)
                { return true; }
            }

            currCoordinate.Leave();
            nextCoordinate.Land();
            return false;
        }
    }
}
