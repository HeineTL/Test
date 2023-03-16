using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class Fighter
    {
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Stamina { get; private set; }
        public string Name { get; private set; }

        public Fighter(int health, int strength, int stamina, string name)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
            Name = name;
        }

        public bool Damage(Fighter enemy)
        {
            if (Stamina < 10)
            {
                Stamina += 30;
                return false;
            }
            else
            {
                enemy.Health = enemy.Health - Strength;
                Stamina -= 10;
                return true;
            }
        }

    }
}
