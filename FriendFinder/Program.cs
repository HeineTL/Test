using System;

namespace FriendFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FaceFriend FF = new FaceFriend();

            Console.WriteLine("[===FaceFriend===]");
            Console.WriteLine("Welcome! Type /help for a list of commands.");
            FF.InputHandler();
            

        }
    }
}
