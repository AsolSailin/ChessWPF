//Garaeva Ruslana, Chess 3, 220, 24.04.22

using System;

namespace Chess3
{
    class King : Piece
    {
        public King(string str) : base(str)
        {
        }

        public override bool IsRightMove(string str)
        {
            var (x, y) = Coordinates(str);
            return Math.Abs(X - x) <= 1 && Math.Abs(Y - y) <= 1;
        }
    }
}
