//Ziyatdinov Kamil 220 group "Chess 4" ?.06.2022


using System;

namespace Chess_3
{
    public class Queen : Chessman
    {
        public Queen(string position) : base(position) { }

        public Queen(int x, int y) : base(x, y) { }

        public override bool isRightMove(int x, int y)
        {
            return (Math.Abs(X - x) == Math.Abs(Y - y)) || (X == x || Y == y);
        }
    }
}
