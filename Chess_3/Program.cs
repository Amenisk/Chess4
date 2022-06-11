//Ziyatdinov Kamil 220 group "Chess 4" ?.06.2022

using System;

namespace Chess_3
{
    class Program
    {
        static void Main(string[] args)
        {
            King king = new King("E7");
            king.Move("E8");
            king.Move(1, 5);

            Queen queen = new Queen(2, 4);
            queen.Move(1, 4);
            queen.Move(2, 9);

            Bishop bishop = new Bishop("D5");
            bishop.Move("B3");
            bishop.Move(2, 3);


            Rook rook = new Rook(5, 5);
            rook.Move(0, 5);
            rook.Move("E8");

            Knight knight = new Knight("A1");
            knight.Move("B3");
            knight.Move("H8");
        }
    }
}
