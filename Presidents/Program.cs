using System;

namespace Presidents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //President president = new President("Bill Clinton", "Democratic", "1993–2001");

            //president.show();

            Presidents presidents = new Presidents();

            presidents.showPresidentByYear(1935);
        }
    }
}
