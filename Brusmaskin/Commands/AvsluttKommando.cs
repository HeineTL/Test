using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Brusmaskin.Commands
{
    internal class AvsluttKommando : IKommando
    {
        private Bruker _bruker;
        private Brusautomat _brusautomat;

        public string Kommando = "/avslutt";

        public AvsluttKommando(Bruker bruker, Brusautomat brusautomat)
        {
            _bruker = bruker;
            _brusautomat = brusautomat;
        }

        public void Run()
        {
            Environment.Exit(0);
        }

        public string GetKommando() => Kommando;
    }
}
