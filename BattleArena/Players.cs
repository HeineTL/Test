using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Players
    {
        private List<Player> _players;

        public Players(params Player[] players)
        {
            _players = new List<Player>(players);
        }

       public void showPlayers()
        {
            foreach(Player player in _players)
            {
                Console.WriteLine(player.getName() + player.getHealth());
            }
        }

        public void FightRandomly()
        {
            Random random = new Random();

            var playerIndex1 = random.Next(0, _players.Count);
            var playerIndex2 = random.Next(0, _players.Count);
            while(playerIndex2 == playerIndex1)
            {
                playerIndex2 = random.Next(0, _players.Count);
            }

            Fight(_players[playerIndex1], _players[playerIndex2]);
        }

        public void Fight(Player player1, Player player2)
        {
            Random random = new Random();

            Player[] tempPlayers = new Player[2] { player1, player2 };

            Console.WriteLine($@"{player1.getName()}[{player1.getHealth()}] is fighting {player2.getName()}[{player2.getHealth()}]!");

            var randomPlayerIndex = random.Next(0, 1);

            tempPlayers[randomPlayerIndex].removeHealth(1);

            Console.WriteLine($@"{tempPlayers[randomPlayerIndex].getName()}[{tempPlayers[randomPlayerIndex].getHealth()}] lost and took damage");
        }

        public void FightTillSomeoneDies()
        {
            bool everyoneAlive = true;

            while(everyoneAlive)
            {
                FightRandomly();
                foreach(Player player in _players) { 
                    if(player.getHealth() == 0)
                    {
                        everyoneAlive = false;
                        Console.WriteLine($@"{player.getName()}[{player.getHealth()}] died! GG");
                        break;
                    }
                }
            }
        }

        
    }
}
