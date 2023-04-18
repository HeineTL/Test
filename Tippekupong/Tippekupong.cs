using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tippekupong
{
    internal class Tippekupong
    {
        private int _homeGoals;
        private int _awayGoals;
        private string _bet;
        private bool _isRunning;

        public Tippekupong()
        {
            _homeGoals = 0;
            _awayGoals = 0;
        }

        public void StartMatch()
        {
            _isRunning = true;
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            _bet = Console.ReadLine();
            while (_isRunning)
            {
                _isRunning = MatchRunning();
            }
            IsBetCorrect();
        }

        public bool MatchRunning()
        {
            Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
            var command = Console.ReadLine();
            if (command == "X") return false;
            if (command == "H") _homeGoals++;
            else if (command == "B") _awayGoals++;
            Console.WriteLine(GetScore());
            return true;
        }

        public void IsBetCorrect()
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            var isBetCorrect = _bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }

        public string GetScore()
        {
            return $@"Stillingen er {_homeGoals}-{_awayGoals}.";
        }

    }
}
