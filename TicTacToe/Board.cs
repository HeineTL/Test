using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        public List<BoardSquare> list = new List<BoardSquare>();

        public Board()
        {
            for (int i = 0; i < 9; i++)
            {
                list.Add(new BoardSquare());
            }
        }

        public void drawBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine("");
                }
                list[i].show();
            }
        }
    }
}
