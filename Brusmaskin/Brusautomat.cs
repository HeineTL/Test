using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brusmaskin
{
    internal class Brusautomat
    {
        private readonly List<Drikke> _utvalg;
        private int _saldo { get; set; }

        public Brusautomat()
        {
            _saldo = 0;
            _utvalg = new List<Drikke>
            {
                new Drikke("Cola", 20, 5),
                new Drikke("Pepsi", 22, 3),
                new Drikke("Dr Pepper", 18, 7),
                new Drikke("Solo", 15, 1),
                new Drikke("Villa", 16, 6),
            };
        }

        public void ØkSaldo(int mynt, Bruker bruker)
        {
            if (!bruker.FjernPenger(mynt))
            {
                Console.WriteLine("Du har ikke nok penger!");
            }
            else
            {
                _saldo += mynt;
                Console.WriteLine($"Du la på {mynt} - ny saldo er {_saldo}");
            }
        }

        public void ReturnerSaldo(Bruker bruker)
        {
            Console.WriteLine("Du fikk tilbake " + _saldo);
            bruker.FåPenger(_saldo);
            _saldo = 0;
        }

        public void LeggTilDrikke(Drikke drikke)
        {
            for(int i = 0; i < _utvalg.Count; i++)
            {
                if (_utvalg[i].Navn == drikke.Navn && _utvalg[i].Pris == drikke.Pris)
                {
                    _utvalg[i].Antall += drikke.Antall;
                    return;
                }
            }

            _utvalg.Add(drikke);

        }

        public void ViseUtvalg()
        {
            Console.WriteLine("Utvalg: ");
            foreach (var drikke in _utvalg)
            {
                Console.WriteLine($@"-  {drikke.Navn} - {drikke.Pris}kr - {drikke.Antall} stk.");
            }

            //var inkl = visPris | visLagerbeholdning ? "inkl." : "";
            //var pris = visPris ? "pris" : "";
            //var beholdning = visLagerbeholdning ? "beholdning" : "";
            //var kombinert = visPris && visLagerbeholdning
            //    ? $"{pris} og {beholdning}"
            //    : pris + beholdning;
            //var header = $"Utvalg {inkl} {kombinert}";
            //Console.WriteLine(header);
            //foreach (var item in _utvalg)
            //{
            //    Console.Write("  ");
            //    item.Show(visPris, visLagerbeholdning);
            //}

            //Console.WriteLine();
        }

        public void Kjøp(string navn)
        {
            var drikke = FinnDrikke(navn);

            if (drikke == null)
            {
                Console.WriteLine("Har ikke drikken");
                return;
            }

            var pris = drikke.Pris;
            if (_saldo < pris)
            {
                Console.WriteLine($"Saldo er {_saldo} - og prisen er {pris} - ikke nok!");
                return;
            }

            _saldo -= pris;
            FjernProdukt(drikke);
        }

        private Drikke? FinnDrikke(string navn)
        {
            foreach (var drink in _utvalg)
            {
                if (drink.Navn == navn)
                {
                    return drink;
                }
            }
            return null;
        }

        public void FjernProdukt(Drikke drikke)
        {
            drikke.Antall--;
            Console.WriteLine(@$"Du kjøpte {drikke.Antall} {drikke.Navn}");
        }

        public void VisKommandoer()
        {
            Console.WriteLine("Velkommen!");
            Console.WriteLine("/kjøp <navn>");
            Console.WriteLine("/legginnpenger <nummer>");
            Console.WriteLine("/avslutt");
        }
    }
}
