﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tetris99
{
    class Point
    {
        public int x;
        public int y;
        char c;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c); 
        }
        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            c = sym;
        }

        internal void Move(Direction dir)
        {
           switch (dir)
           {
                case Direction.Down:
                    y++;
                    break;
                case Direction.Left:
                    x--;
                    break;
                case Direction.Right:
                    x++;
                    break;
           }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        
    }
}