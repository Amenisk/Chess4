//Ziyatdinov Kamil 220 group "Chess 4" 16.06.2022

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
                return new Pawn(x, y);

            default:
                throw new Exception("This kind of chessman is not found!");
        }

    }

    public static Chessman MakeFigure(string codeChessman, string position)
    {
        switch (codeChessman)
        {
            case "King":
            case "1":
            case "K":
                return new King(position);

            case "Queen":
            case "2":
            case "Q":
                return new Queen(position);

            case "Rook":
            case "3":
            case "R":
                return new Rook(position);

            case "Bishop":
            case "4":
            case "B":
                return new Bishop(position);

            case "Knight":
            case "5":
            case "N":
                return new Knight(position);

            case "Pawn":
            case "6":
            case "P":
                return new Pawn(position);

            default:
                throw new Exception("This kind of chessman is not found!");
        }

    }
}
