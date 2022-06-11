//Ziyatdinov Kamil 220 group "Chess 4" ?.06.2022


using System;

namespace Chess_3
{
    public class King : Chessman
    {
        public King(string position) : base(position) { }

        public King(int x, int y) : base(x, y) { }

        public override bool isRightMove(int x, int y)
        { 
            return Math.Abs(X - x) <= 1 && Math.Abs(Y - y) <= 1;
        }
    }
}
