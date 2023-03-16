using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class Arena
    {
        public Arena() { }

        public void Trade(Fighter fighter1, Fighter fighter2)
        {
            if (fighter1.Damage(fighter2))
            {
                Console.WriteLine($"{fighter1.Name} damages {fighter2.Name} for {fighter1.Strength} damage. {fighter2.Name} now has {fighter2.Health} health left.");
            }
            else
            {
                Console.WriteLine($"{fighter1.Name} doesn't have enough stamina and needs to skip this round to recharge.");
            }
        }

        public void Battle(Fighter fighter1, Fighter fighter2)
        {
            while(fighter1.Health > 0 && fighter2.Health > 0)
            {
                Trade(fighter1, fighter2);
                Trade(fighter2, fighter1);
                Console.WriteLine();
            }

            if(fighter1.Health <= 0)
            {
                Console.WriteLine($"{fighter2.Name} IS THE WINNER!!!");
            }
            if(fighter2.Health <= 0)
            {
                Console.WriteLine($"{fighter1.Name} IS THE WINNER!!!");
            }

        }
    }
}
