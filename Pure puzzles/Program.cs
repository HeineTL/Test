using System;

namespace Pure_puzzles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diamond diamond = new Diamond(10);
            //Console.WriteLine("Length of diamond?");
            //int length = Int32.Parse(Console.ReadLine());

            diamond.generateDiamond(true);
            diamond.generateDiamond();
        }
    }
}
