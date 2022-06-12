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
                break;

            case "Queen":
            case "2":
            case "Q":
                return new Queen(x, y);
                break;

            case "Rock":
            case "3":
            case "R":
                return new Rook(x, y);
                break;

            case "Bishop":
            case "4":
            case "B":
                return new Bishop(x, y);
                break;

            case "Knight":
            case "5":
            case "N":
                return new Knight(x, y);
                break;

            case "Pawn":
            case "6":
            case "P":
                return new King(x, y);
                break;

            default:
                throw new Exception("This kind of chessman is not found!");
                break;
        }

    }
}
