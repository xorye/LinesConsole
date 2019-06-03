using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class Square
    {
        private Boolean Up, Down, Left, Right, Filled;
        private int X, Y;

        public Square(int x, int y)
        {
            Up = false;
            Down = false;
            Left = false;
            Right = false;
            Filled = false;
            X = x;
            Y = y;
        }
    }
}
