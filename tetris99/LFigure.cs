﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tetris99
{
    class LFigure : Figure , IRotateToDir
    {
        public LFigure(int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x, y + 2, sym);
            points[3] = new Point(x + 1, y + 2, sym);

            Draw();
        }

        public override void Rotate()
        {
            var dir = RotateDirection();

            points[1].X = points[3].X;
            points[1].Y = points[3].Y;

            switch (dir)
            {
                case Direction.Right:
                    RotateRight();
                    break;

                case Direction.Left:
                    RotateLeft();
                    break;

                case Direction.Up:
                    RotateUp();
                    break;

                case Direction.Down:
                    RotateDown();
                    break;
            }
        }

        public void RotateRight()
        {
            points[0].X = points[1].X + 1;
            points[0].Y = points[1].Y;

            points[3].X = points[2].X;
            points[3].Y = points[2].Y + 1;
        }

        public void RotateDown()
        {
            points[0].X = points[3].X;
            points[0].Y = points[3].Y + 1;

            points[3].X = points[2].X - 1;
            points[3].Y = points[2].Y;
        }       

        public void RotateLeft()
        {
            points[0].X = points[3].X - 1;
            points[0].Y = points[3].Y;

            points[3].X = points[2].X;
            points[3].Y = points[2].Y - 1;
        }

        public void RotateUp()
        {
            points[0].X = points[3].X;
            points[0].Y = points[3].Y - 1;

            points[3].X = points[2].X + 1;
            points[3].Y = points[2].Y;
        }

        public Direction RotateDirection()
        {
            if (points[1].Y == points[2].Y)
            {
                if (points[1].X == points[2].X - 1)
                    return Direction.Up;
                else
                    return Direction.Down;
            }
            else if (points[1].Y == points[2].Y - 1)
            {
                return Direction.Right;
            }
            else
            {
                return Direction.Left;
            }
        }


    }
}
