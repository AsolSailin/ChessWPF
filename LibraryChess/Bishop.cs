//Garaeva Ruslana, Chess 4, 220, 06.22

using System;

namespace LibraryChess
{
    class Bishop : Piece
    {
        public Bishop(int newX, int newY) : base(newX, newY)
        { }

        public Bishop(string position) : base(position)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return (Math.Abs(x - newX) == Math.Abs(y - newY));
        }
    }
}
