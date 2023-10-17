//Garaeva Ruslana, Chess 3, 220, 24.04.22

using System;

namespace Chess3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Piece piece1 = new Bishop("d5");
            Console.WriteLine(piece1.Move("e6")); //right

            Piece piece2 = new Bishop("d5");
            Console.WriteLine(piece2.Move("e5")); //incorrect

            Piece piece3 = new King("f5");
            Console.WriteLine(piece3.Move("f6")); //right

            Piece piece4 = new King("f5");
            Console.WriteLine(piece4.Move("f7")); //incorrect

            Piece piece5 = new Knight("d4");
            Console.WriteLine(piece5.Move("e6")); //right

            Piece piece6 = new Knight("d4");
            Console.WriteLine(piece6.Move("e4")); //incorrect

            Piece piece7 = new Queen("d4");
            Console.WriteLine(piece7.Move("e4")); //right

            Piece piece8 = new Queen("d4");
            Console.WriteLine(piece8.Move("e2")); //incorrect

            Piece piece9 = new Rook("d5");
            Console.WriteLine(piece9.Move("d6")); //right

            Piece piece10 = new Rook("d5");
            Console.WriteLine(piece10.Move("e4")); //incorrect
        }
    }
}
