//Garaeva Ruslana, Chess 4, 220, 06.22

using System;
using System.Text.RegularExpressions;

namespace LibraryChess
{
    public abstract class Piece
    {
        protected int x;
        protected int y;

        public Piece(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public Piece(string position)
        {
            (x, y) = Parse(position);
        }

        public abstract bool TestMove(int newX, int newY);

        public bool TestMove(string position)
        {
            (int newX, int newY) = Parse(position);
            return TestMove(newX, newY);
        }

        public bool Move(string position)
        {
            (int x, int y) = Parse(position);
            return Move(x, y);
        }

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }

        public static (int, int) Parse(string position)
        {
            if (!Regex.IsMatch(position, "[A-H][1-8]"))
            {
                throw new Exception("Invalid position");
            }
            return (position[0] - 'A', position[1] - '1');
        }
    }
}

