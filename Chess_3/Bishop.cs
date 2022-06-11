//Ziyatdinov Kamil 220 group "Chess 4" ?.06.2022


using System;

namespace Chess_3
{
    public class Bishop : Chessman
    {
        public Bishop(string position) : base(position) { }

        public Bishop(int x, int y) : base(x, y) { }

        public override bool isRightMove(int x, int y)
        {
            return Math.Abs(X - x) == Math.Abs(Y - y);
        }
    }
}
