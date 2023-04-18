using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Question
    {
        public string QuestionText { get; private set; }
        public String[] Options { get; private set; }
        public Char CorrectAnswer { get; private set; }

        public Question(string questionText, char correctAnswer, params string[] options)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
        }

        public int RunQuestion()
        {
            Console.WriteLine(QuestionText);

            char startChar = 'A';

            for (int i = 0; i < Options.Length; i++)
            {
                char tempChar = (char) (Convert.ToInt32(startChar) + i);
                Console.WriteLine($@"  {tempChar}: {Options[i]}");
            }

            return CheckQuestion();
        }

        private int CheckQuestion()
        {
            Console.Write("Skriv inn ditt svar: ");
            var answerRaw = Console.ReadLine();
            var answer = answerRaw.ToCharArray();

            if (answer[0] == CorrectAnswer)
            {
                Console.WriteLine("Riktig!");
                return 1;
            }
            else
            {
                Console.WriteLine("Feil!");
                return 0;
            }

        }
    }
}
