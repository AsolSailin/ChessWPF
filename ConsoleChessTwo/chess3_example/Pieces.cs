/*
*   Chess pieces 3 ver 3
*   With classes, factory and enum
*   DKY 25.04.2021 
*/

using System;
using System.Text.RegularExpressions;

namespace Chess
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

    public class King : Piece
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

    class Rook : Piece
    {
        public Rook(int newX, int newY) : base(newX, newY)
        { }

        public Rook(string position) : base(position)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return (x == newX || y == newY);
        }

    }

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