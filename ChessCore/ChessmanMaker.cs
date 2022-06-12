using System;
using ChessCore;

public static class ChessmanMaker
{
	public static Chessman MakeFigure(string codeChessman, int x, int y)
    {
        switch (codeChessman)
        {
            case "King":
            case "1":
            case "K":
                return new King(x, y);

            case "Queen":
            case "2":
            case "Q":
                return new Queen(x, y);

            case "Rock":
            case "3":
            case "R":
                return new Rook(x, y);

            case "Bishop":
            case "4":
            case "B":
                return new Bishop(x, y);

            case "Knight":
            case "5":
            case "N":
                return new Knight(x, y);

            case "Pawn":
            case "6":
            case "P":
                return new King(x, y);

            default:
                throw new Exception("This kind of chessman is not found!");
        }

    }
}
