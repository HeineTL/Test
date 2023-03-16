using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Person
    {
        public string Name { get; private set; }

        public int Kidneys { get; private set; }

        public Person(string name, int kidneys)
        {
            Name = name;
            Kidneys = kidneys;
        }

        public bool removeKidney()
        {
            if (Kidneys > 1)
            {
                Kidneys--;
                return true;
            } else
            {
                return false;
            }
        }

        public bool addKidney()
        {
            if (Kidneys < 2)
            {
                Kidneys++;
                return true;
            } else
            {
                return false;
            }
        }
    }

}
