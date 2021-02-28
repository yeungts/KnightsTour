using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTour
{
    partial class ControlMethods : Control
    {
        public override bool HeuristicsPlay(Coordinate currCoordinate, Coordinate[,]
            coordinates, Random r)
        {
            int count = 0;
            int move, newX, newY;
            int? accessibility = null;

            ArrayList potentialCoordinates = new ArrayList();

            // Using random to generate random move, and store all possible moves for further action
            do
            {
                move = r.Next(8);
                newX = base.MovingX(move, currCoordinate.X);
                newY = base.MovingY(move, currCoordinate.Y);

                if (((newX >= 0 && newX <= 7)
                    && (newY >= 0 && newY <= 7))
                    && !coordinates[newX, newY].isLanded)
                {
                    // Getting all the possible moves first
                    potentialCoordinates.Add(coordinates[newX, newY]);
                    ((Coordinate)potentialCoordinates[potentialCoordinates.Count-1]).MoveType = move;
                }

                count++;
            } while (count < 30);

            // Going through all types of move and see if there will be any possible move 
            // if the previous code block can't not genarate any possible move
            if (count > 30 || potentialCoordinates.Count == 0)
            {
                potentialCoordinates.Clear();

                for (int i = 0; i < 8; i++)
                {
                    newX = MovingX(i, currCoordinate.X);
                    newY = MovingY(i, currCoordinate.Y);

                    if (((newX >= 0 && newX <= 7)
                        && (newY >= 0 && newY <= 7))
                        && !coordinates[newX, newY].isLanded)
                    {
                        potentialCoordinates.Add(coordinates[newX, newY]);
                        ((Coordinate)potentialCoordinates[potentialCoordinates.Count-1]).MoveType = i;
                    }
                }

                if (potentialCoordinates.Count == 0)
                { return true; }
            }

            // Check the accessibilty of different coordinates and pick out the one with the 
            // lowest accessibility
            for (int i = 0; i < potentialCoordinates.Count; i++)
            {
                if (accessibility == null ||
                    ((Coordinate)potentialCoordinates[i]).Accessibility < accessibility)
                {
                    accessibility = ((Coordinate)potentialCoordinates[i]).Accessibility;
                    newX = ((Coordinate)potentialCoordinates[i]).X;
                    newY = ((Coordinate)potentialCoordinates[i]).Y;
                    coordinates[newX, newY].MoveType = ((Coordinate)potentialCoordinates[i]).MoveType;
                }
            }

            currCoordinate.Leave();
            coordinates[newX, newY].Land();
            return false;
        }
    }
}
