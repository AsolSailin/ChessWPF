//Garaeva Ruslana, Chess 3, 220, 24.04.22

using System;

namespace Chess3
{
    class Rook : Piece
    {
        public Rook(string str) : base(str)
        {
        }

        public override bool IsRightMove(string str)
        {
            var (x, y) = Coordinates(str);
            return X == x || Y == y;
        }
    }
}
