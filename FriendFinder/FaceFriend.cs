using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FriendFinder
{
    internal class FaceFriend
    {
        Users LoggedInUser = new Users("Heine", 19);

        public FaceFriend() { }

        public void Header()
        {
            Console.Clear();
            Console.WriteLine("[===FaceFriend===]");
        }

        public void InputHandler()
        {
            string InputRaw = Console.ReadLine();

            string[] Input = InputRaw.Split(' ');

            Command(Input);
        }

        public void Command(string[] args)  //<args>
        {
            Header();

            string Command = args[0].ToLower();

            if (args.Length == 1)
            {
                switch (args[0])
                {
                    case "/help":
                        string[] commands = { "/help", "/showfriends", "/addfriend <name>", "/removefriend <name>" };
                        foreach (string cmd in commands)
                        {
                            Console.WriteLine(cmd);
                        }
                        break;
                    case "/showfriends":
                        LoggedInUser.ShowFriends();
                        break;
                    default:
                        Console.WriteLine("Unknown/wrong command, type /help for a list of commands.");
                        break;
                }
            }
            else if (args.Length == 2)
            {
                string friendName = args[1];

                switch (args[0])
                {
                    case "/addfriend":
                        LoggedInUser.AddFriend(friendName);
                        Console.WriteLine($"{friendName} is now your friend!");
                        break;
                    case "/removefriend":
                        LoggedInUser.RemoveFriend(friendName);
                        Console.WriteLine($"{friendName} is no longer your friend!");
                        break;
                    default:
                        Console.WriteLine("Unknown/wrong command, type /help for a list of commands.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Unknown/wrong command, type /help for a list of commands.");
            }

            InputHandler();
        }
    }
}
