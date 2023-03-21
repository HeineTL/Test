using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class PasswordGenerator
    {
        public List<int> PassTypes = new List<int>();

        public int passwordLength = 15;

        Random random = new Random();

        public void GeneratePassword()
        {
            string Password = string.Empty;

            for (int i = 0; i < passwordLength; i++)
            {
                Password = Password.Insert(Password.Length, randomChar().ToString());
            }


            Console.WriteLine(Password);
        }

        public char randomChar()
        {
            int[,] charIndex = new int[,] { { 65, 90 }, { 97, 122 }, { 33, 38 }, { 48, 57 } };
            //charIndex[0] = A-Z
            //charIndex[1] = a-z
            //charIndex[2] = Special characters (!"#$%&)
            //charIndex[3] = Numbers

            int randomCharIndex = PassTypes[random.Next(0, PassTypes.Count)];

            int randomChar = random.Next(charIndex[randomCharIndex, 0], charIndex[randomCharIndex, 1]);

            return Convert.ToChar(randomChar);
        }

        public void setFormat(string args)
        {
            if (args.Contains("-AZ")) PassTypes.Add(0);
            if (args.Contains("-az")) PassTypes.Add(1);
            if (args.Contains("-sc")) PassTypes.Add(2);
            if (args.Contains("-09")) PassTypes.Add(3);
        }

        public void setPasswordLength(int length)
        {
            passwordLength = length;
        }


    }
}
