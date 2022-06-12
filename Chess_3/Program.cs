//Ziyatdinov Kamil 220 group "Chess 4" ?.06.2022

using System;
using ChessCore;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1234);
            string chessName = Console.ReadLine();
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Chessman chessman = ChessmanMaker.MakeFigure(chessName, x1, y2);
                chessman.Move(x2, y2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
