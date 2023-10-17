//Garaeva Ruslana, Chess 6, 220, 06.22

using System;

namespace LibraryChess
{
    class Knight : Piece
    {
        public Knight(int newX, int newY) : base(newX, newY)
        { }

        public Knight(string position) : base(position)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return ((Math.Abs(x - newX) == 2 && Math.Abs(y - newY) == 1) ||
                    (Math.Abs(x - newX) == 1 && Math.Abs(y - newY) == 2));
        }
    }
}
