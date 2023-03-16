using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void game()
            {
                Console.WriteLine("=====Krokkedillespill=====");

                Random random = new Random();
                int num1 = random.Next(1, 10);
                int num2 = random.Next(1, 10);

                string correctAnswer;

                if (num1 < num2)
                {
                    correctAnswer = "<";
                }
                else if (num1 > num2)
                {
                    correctAnswer = ">";
                }
                else
                {
                    correctAnswer = "=";
                }

                Console.WriteLine(num1 + " : " + num2);

                string userResponse = Console.ReadLine();

                if (userResponse == correctAnswer)
                {
                    Console.WriteLine("Riktig!");
                }
                else
                {
                    Console.WriteLine("Feil!");
                }

                Console.WriteLine("Vil du spille igjen? (J/N)");
                var playAgain = Console.ReadLine();
                if (playAgain == "J" || playAgain == "j")
                {
                    Console.Clear();
                    game();
                }
                else
                {
                    return;
                }

            }

            game();
        }
    }
}
