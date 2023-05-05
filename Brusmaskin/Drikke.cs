using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brusmaskin
{
    internal class Drikke
    {
        public string Navn { get; }
        public int Antall { get; set; }
        public int Pris { get; }

        public Drikke(string navn, int pris, int antall)
        {
            Navn = navn;
            Antall = antall;
            Pris = pris;
        }

        //public bool MatchesNameAndIsAvailable(string navn)
        //{
        //    return _navn == navn && _antall > 0;
        //}

        //public void Show(bool visPris = true, bool visLagerbeholdning = true)
        //{
        //    Console.Write(_navn);
        //    if (visPris)
        //    {
        //        Console.Write($" - koster {Pris}kr");
        //    }

        //    if (visLagerbeholdning)
        //    {
        //        Console.Write($" - {_antall} på lager");

        //    }
        //    Console.WriteLine();
        //}
    }
}
