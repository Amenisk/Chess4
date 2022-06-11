//Ziyatdinov Kamil 220 group "Chess 4" ?.06.2022

using System;

namespace Chess_3
{
    public class Rook : Chessman
    { 
        public Rook(string position) : base(position) { }

        public Rook(int x, int y) : base(x, y) { }

        public override bool isRightMove(int x, int y)
        {
            return X == x || Y == y;
        }
    }
}
