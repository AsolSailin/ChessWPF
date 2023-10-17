//Garaeva Ruslana, Chess 3, 220, 24.04.22

using System;

namespace Chess3
{
    class Queen : Piece
    {
        public Queen(string str) : base(str)
        {
        }

        public override bool IsRightMove(string str)
        {
            var (x, y) = Coordinates(str);
            return Math.Abs(X - x) == Math.Abs(Y - y) || (x == X || y == Y);
        }
    }
}
