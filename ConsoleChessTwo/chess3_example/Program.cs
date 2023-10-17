/*
*   Chess pieces 3 ver 3
*   With classes, factory and enum
*   DKY 25.04.2021 
*/

using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Piece code + digit coordinates
                K
                1
                1
                2
                2
            */
            {
                string chess = Console.ReadLine();
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Piece f = PieceMaker.Make(chess, x1, y1);
                    Console.WriteLine(f.Move(x2, y2) ? "YES" : "NO");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            /*
             * Piece name + chess coordinates
                King
                A1
                B2
            */
            {
                string chess = Console.ReadLine();
                string pos1 = Console.ReadLine();
                string pos2 = Console.ReadLine();

                try
                {
                    Piece f = PieceMaker.Make(chess, pos1);
                    Console.WriteLine(f.Move(pos2) ? "YES" : "NO");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
