using System;

namespace Bossfight
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fighter Hero = new Fighter(275, 25, 63, "Hero");
            Fighter Boss = new Fighter(25, 15, 84, "Boss");

            Arena arena = new Arena();

            arena.Battle(Hero, Boss);
            
        }
    }
}
