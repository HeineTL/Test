using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Quiz
    {
        private List<Question> _quiz;

        public Quiz()
        {
            _quiz = new List<Question>
            {
                new Question("Hva er hovedstaden i Norge?", 'A', /*Options:*/ "Oslo", "Bergen", "Trondheim"),
                new Question("Hva er den største planeten i solsystemet vårt?", 'B', /*Options:*/ "Mars", "Jupiter",
                    "Venus"),
                new Question("Hva heter den største øya i verden?", 'A', /*Options:*/ "Grønland", "Australia",
                    "Madagaskar"),
                new Question("Hva er hovedingrediensen i guacamole?", 'B', /*Options:*/ "Tomat", "Avokado", "Paprika"),
                new Question("Hva heter hovedpersonen i To Kill a Mockingbird av Harper Lee?", 'B', /*Options:*/
                    "Atticus Finch", "Scout Finch", "Jem Finch"),
            };
        }

        public void RunQuiz()
        {
            var points = 0;
            foreach (Question question in _quiz)
            {
                points += question.RunQuestion();
                Console.WriteLine(@$"Du har nå {points} poeng!");
                Console.WriteLine();
            }
        }
    }
}
