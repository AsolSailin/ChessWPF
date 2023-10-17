//Garaeva Ruslana, Chess 3, 220, 24.04.22
using System;
using System.Collections.Generic;

namespace Chess3
{
    class Piece
    {
        public int X;
        public int Y;

        public static Dictionary<string, int> letter = new Dictionary<string, int>()
        {
            {"a", 1}, {"b", 2}, {"c", 3}, {"d", 4},
            {"e", 5}, {"f", 6}, {"g", 7}, {"h", 8}
        };
        public Piece (string str)
        {
            (X, Y) = Coordinates(str);
        }

        public Tuple<int, int> Coordinates(string str)
        {
            int x = letter[str[0].ToString()];
            int y = int.Parse(str[1].ToString());

            return new Tuple<int, int>(x, y);
        }

        public virtual bool IsRightMove(string str)
        {
            return true;
        }

        public bool Move (string str)
        {
            if (!IsRightMove(str))
            {
                throw new Exception("The move is not correct." +
                    " You need to select other coordinates.");
            }

            return true;
        }
        }
    }

