using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Brusmaskin
{
    internal class Bruker
    {
        private int _penger;

        public string[] Kommando;
        
        public Bruker(int penger)
        {
            _penger = penger;
        }

        public void FåPenger(int amount) => _penger+=amount;

        public bool FjernPenger(int amount)
        {
            if (_penger - amount < 0) return false;

            _penger -= amount;
            return true;
        }

        public void KjøpFraBrusautomat(Brusautomat brusautomat)
        {
            brusautomat.Kjøp(Kommando[1]);
        }

        public void VelgKommando()
        {
            Kommando = Console.ReadLine().Split(" ");

        }

    }
}
