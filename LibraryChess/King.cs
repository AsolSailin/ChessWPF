//Garaeva Ruslana, Chess 4, 220, 06.22

using System;

namespace LibraryChess
{
    class King : Piece
    {
        public King(int newX, int newY) : base(newX, newY)
        { }

        public King(string position) : base(position)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return Math.Abs(x - newX) <= 1 && Math.Abs(y - newY) <= 1;
        }
    }
}
