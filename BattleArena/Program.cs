using System;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player john = new Player("John", 10);
            Player martin = new Player("Martin", 10);
            Player chris = new Player("Chris", 10);
            Player andrew = new Player("Andrew", 10);

            Players players = new Players(john, martin, chris, andrew);

            players.FightTillSomeoneDies();

        }
    }
}
