using System;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Bernt = new Person("Bernt", 1);
            Person Kåre = new Person("Kåre", 1);

            if(Kåre.removeKidney())
            {
                if(Bernt.addKidney())
                {
                    Console.WriteLine("Operasjonen var suksessfull!");
                } else
                {
                    Console.WriteLine("Bernt har allerede nok nyrer!");
                }
            } else
            {
                Console.WriteLine("Kåre har ikke en nyre å gi vekk!");
            }

        }
    }
}
