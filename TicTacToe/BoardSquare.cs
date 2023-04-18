using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class BoardSquare
    {
        public string _square;

        public bool isEmpty()
        {
            return _square == null ? true : false;
        }

        public bool take(string player)
        {
            if (isEmpty()) { _square = player; return true; }
            else { return false; }
        }

        public void show()
        {
            Console.Write(isEmpty() ? "_" : _square);
        }


    }
}
