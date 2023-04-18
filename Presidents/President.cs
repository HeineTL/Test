using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presidents
{
    internal class President
    {
        public string Name { get; private set; }
        public string Party { get; private set; }
        public int YearFrom { get; private set; }
        public int YearTo { get; private set; }

        public President(string name, string party, string year)
        {
            _name = name;
            _party = party;
            var parts = year.Replace("*", string.Empty).Split('-', '–');
            var yearFrom = parts[0];
            _yearFrom = Convert.ToInt32(yearFrom);
            if (parts.Length < 2)
            {
                if (!year.Contains('-') && !year.Contains('–'))
                {
                    _yearTo = _yearFrom;
                }
                return;
            }
            var yearTo = parts[1];
            if (yearTo.Length == 0) return;
            yearTo = yearFrom.Substring(0, 4 - yearTo.Length) + yearTo;
            _yearTo = Convert.ToInt32(yearTo);

        }

        public void show()
        {
            Console.WriteLine(_yearFrom);
            Console.WriteLine(_yearTo);
        }
    }
}
