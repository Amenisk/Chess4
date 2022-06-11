//Ziyatdinov Kamil 220 group "Chess 4" ?.06.2022


using System;

namespace Chess_3
{
    public class Knight : Chessman
    {
        public Knight(string position) : base(position) { }

        public Knight(int x, int y) : base(x, y) { }

        public override bool isRightMove(int x, int y)
        {
            return Math.Abs(X - x) == 1 && Math.Abs(Y - y) == 2
                || Math.Abs(X - x) == 2 && Math.Abs(Y - y) == 1;
        }
    }
}
