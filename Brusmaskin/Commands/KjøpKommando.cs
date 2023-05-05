using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brusmaskin.Commands
{
    internal class KjøpKommando : IKommando
    {
        private Bruker _bruker;
        private Brusautomat _brusautomat;

        public string Kommando = "/kjøp";

        public KjøpKommando(Bruker bruker, Brusautomat brusautomat)
        {
            _bruker = bruker;
            _brusautomat = brusautomat;
        }

        public void Run()
        {
            _bruker.KjøpFraBrusautomat(_brusautomat);
            Console.WriteLine("Yes");
        }

        public string GetKommando() => Kommando;
    }
}
