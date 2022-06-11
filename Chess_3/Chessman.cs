//Ziyatdinov Kamil 220 group "Chess 4" ?.06.2022


using System;
using System.Collections.Generic;

namespace Chess_3
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

        public int  X { get; set; }
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
}
