using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Player
    {
        private string _name;
        private int _health;

        public Player(string name, int health) {
            _name = name;
            _health = health;
        }

        public void addHealth(int healthChange)
        {
            _health += healthChange;
        }

        public void removeHealth(int healthChange)
        {
            _health -= healthChange;
        }

        public int getHealth()
        {
            return _health;
        }

        public string getName()
        {
            return _name;
        }



    }
}
