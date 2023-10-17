//Garaeva Ruslana, Chess 4, 220, 06.22

using System;

namespace LibraryChess
{
    class Pawn : Piece
    {
        public Pawn(int newX, int newY) : base(newX, newY)
        { }

        public Pawn(string position) : base(position)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return ((x == newX && y == 2 && y + 2 >= newY) ||
                    (x == newX && y + 1 == newY));
        }
    }
}
