using System;
using System.Collections.Generic;

namespace ChessCore
{
    public class Chessman
    {
        protected Dictionary<char, int> letters = new Dictionary<char, int>()
    {
        {'A', 1 },
        {'B', 2 },
        {'C', 3 },
        {'D', 4 },
        {'E', 5 },
        {'F', 6 },
        {'G', 7 },
        {'H', 8 }
    };

        protected Dictionary<int, char> numbers = new Dictionary<int, char>()
    {
        {1, 'A' },
        {2, 'B' },
        {3, 'C' },
        {4, 'D' },
        {5, 'E' },
        {6, 'F' },
        {7, 'G' },
        {8, 'H'}
    };

        public int X { get; set; }
        public int Y { get; set; }
        public Chessman(string position)
        {
            this.X = letters[position[0]];
            this.Y = Convert.ToInt32(position[1].ToString());
        }
        public Chessman(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public virtual bool isRightMove(int x, int y)
        {
            return true;
        }
        public void Move(string move)
        {
            int x = letters[move[0]];
            int y = Convert.ToInt32(move[1].ToString());

            if (isRightMove(x, y) && x > 0 && x < 9 && y > 0
                && y < 9 && !(x == X && y == Y))
            {
                this.X = x;
                this.Y = y;

                Console.WriteLine($"{this.GetType().Name} move to {move}");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} " +
                    $"cant move on this position");
            }

        }
        public void Move(int x, int y)
        {
            if (isRightMove(x, y) && x > 0 && x < 9 && y > 0
                && y < 9 && !(x == X && y == Y))
            {
                this.X = x;
                this.Y = y;

                Console.WriteLine($"{this.GetType().Name} " +
                    $"move to {numbers[x].ToString() + y}");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} " +
                    $"cant move on this position");
            }
        }
    }

    public class Bishop : Chessman
    {
        public Bishop(string position) : base(position) { }
        public Bishop(int x, int y) : base(x, y) { }
        public override bool isRightMove(int x, int y)
        {
            return Math.Abs(X - x) == Math.Abs(Y - y);
        }
    }

    public class King : Chessman
    {
        public King(string position) : base(position) { }
        public King(int x, int y) : base(x, y) { }
        public override bool isRightMove(int x, int y)
        {
            return Math.Abs(X - x) <= 1 && Math.Abs(Y - y) <= 1;
        }
    }

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

    public class Queen : Chessman
    {
        public Queen(string position) : base(position) { }
        public Queen(int x, int y) : base(x, y) { }
        public override bool isRightMove(int x, int y)
        {
            return (Math.Abs(X - x) == Math.Abs(Y - y)) || (X == x || Y == y);
        }
    }

    public class Rook : Chessman
    {
        public Rook(string position) : base(position) { }
        public Rook(int x, int y) : base(x, y) { }
        public override bool isRightMove(int x, int y)
        {
            return X == x || Y == y;
        }
    }

    public class Pawn : Chessman
    {
        public Pawn(string position) : base(position) { }
        public Pawn(int x, int y) : base(x, y) { }
        public override bool isRightMove(int x, int y)
        {
            return (y - 1 == Y || y + 1 == Y) && x == X;
        }
    }
    
}
