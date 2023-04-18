using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameConsole
    {
        private Board board = new Board();

        private string currentPlayer = "X";

        private bool noWinner = true;

        internal void Run()
        {
            while (noWinner)
            {
                Console.Clear();
                Console.WriteLine("TicTacToe");
                Console.WriteLine("Skriv 1-9 for å velge rute");
                Console.WriteLine();
                Console.WriteLine("123");
                Console.WriteLine("456");
                Console.WriteLine("789");

                board.drawBoard();

                Console.WriteLine();
                var rawInput = Console.ReadLine();
                var input = Convert.ToInt32(rawInput);
                input--;

                if (board.list[input].take(currentPlayer))
                {
                    checkWinner();
                    changePlayer();
                }

            }

        }

        public void changePlayer()
        {
            if (currentPlayer == "X") { currentPlayer = "O"; } else { currentPlayer = "X"; }
        }

        public void checkWinner()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                {
                    if (board.list[i]._square == currentPlayer &&
                        board.list[i + 1]._square == currentPlayer &&
                        board.list[i + 2]._square == currentPlayer)
                    { //sjekker horizontalt
                        assignWinner();
                        break;
                    }
                }
            }

            for (int j = 0; j < 3; j++)
            {
                if (board.list[j]._square == currentPlayer &&
                    board.list[j + 3]._square == currentPlayer &&
                    board.list[j + 6]._square == currentPlayer)
                { //sjekker vertikalt
                    assignWinner();
                    break;
                }
            }
            if (board.list[0]._square == currentPlayer &&
                board.list[4]._square == currentPlayer &&
                board.list[8]._square == currentPlayer)
            { //kryss høyre
                assignWinner();
            }

            if (board.list[2]._square == currentPlayer &&
                board.list[4]._square == currentPlayer &&
                board.list[6]._square == currentPlayer)
            { //kryss venstre
                assignWinner();
            }


        }

        private void assignWinner()
        {
            noWinner = false;
            Console.WriteLine(currentPlayer + " wins!");
        }
    }
}
