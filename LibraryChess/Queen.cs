//Garaeva Ruslana, Chess 4, 220, 06.22

using System;

namespace LibraryChess
{
    class Queen : Piece
    {
        public Queen(int newX, int newY) : base(newX, newY)
        { }

        public Queen(string position) : base(position)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return (x == newX || y == newY || Math.Abs(x - newX) == Math.Abs(y - newY));
        }
    }
}
