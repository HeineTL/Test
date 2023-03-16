using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFinder
{
    internal class Users
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public List<string> Friends = new List<string>();

        public Users(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void AddFriend(string name)
        {
            Friends.Add(name);
        }

        public void RemoveFriend(string name)
        {
            Friends.Remove(name);
        }
        public void ShowFriends()
        {
            Console.WriteLine("Your friends:");
            foreach (string friend in Friends)
            {
                Console.Write($"{friend} ");
            }
            Console.WriteLine();
        }
    }
}
