using Brusmaskin.Commands;
using System;

namespace Brusmaskin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Brusautomat brusautomat = new Brusautomat();
            Bruker bruker = new Bruker(100);

            IKommando[] kommandoer = new IKommando[] {
            new KjøpKommando(bruker, brusautomat),
            new AvsluttKommando(bruker, brusautomat),
            };

            while (true)
            {
                brusautomat.ViseUtvalg();
                brusautomat.VisKommandoer();
                bruker.VelgKommando();

                foreach (var kommando in kommandoer)
                {
                    if (bruker.Kommando[0] == kommando.GetKommando())
                    {
                        kommando.Run();
                    }
                }
            }

            //new Brusautomat()
            //    .ØkSaldo(20)
            //    .ØkSaldo(5)
            //    .ReturnerSaldo()
            //    .AddDrink("Solo", 25, 6)
            //    .AddDrink("Cola", 35, 6)
            //    .AddDrink("Farris", 5, 23)
            //    .AddDrink("Vann", 1, 1)
            //    .AddDrink("Øl", 75, 3)
            //    .AddDrink("Monster", 30, 223323)
            //    .ViseUtvalg(true, true)
            //    .ViseUtvalg(true, false)
            //    .ViseUtvalg(false, true)
            //    .ViseUtvalg(false, false)
            //    .ØkSaldo(5)
            //    .BuyStuff("Vann")
            //    .BuyStuff("Vann")
            //    .ReturnerSaldo()
            //    .BuyStuff("Vann")
            //    ;
        }
    }
}
