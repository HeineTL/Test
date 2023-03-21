using System;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator passwordgenerator = new PasswordGenerator();

            Console.WriteLine("[===PASSWORD=GENERATOR===]");
            Console.WriteLine("The following parameters can be used for your random password:");
            Console.WriteLine("'-AZ' (A-Z)");
            Console.WriteLine("'-az' (a-z)");
            Console.WriteLine("'-sc' (!#$%&)");
            Console.WriteLine("'-09' (0-9)");

            string passParams = Console.ReadLine();
            passwordgenerator.setFormat(passParams);

            Console.WriteLine("How long do you want the password to be?");
            string length = Console.ReadLine();
            int lengthInt = Int32.Parse(length);
            passwordgenerator.setPasswordLength(lengthInt);

            passwordgenerator.GeneratePassword();

        }
    }
}
