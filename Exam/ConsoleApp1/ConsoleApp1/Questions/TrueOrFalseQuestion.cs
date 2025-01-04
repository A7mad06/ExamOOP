using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions
{
    internal class TrueOrFalseQuestion : Question
    {
        public void AddTrueOrFalseQuestion()
        {
            AddQuestion();
            Answers = new Answer[2];
            Answers[0] = new Answer(1,"True");
            Answers[1] = new Answer(2,"False");
            int _RightAnswerId;
            do
            {
                Console.WriteLine("Please enter the right answer id: (1 for True | 2 for False)");
            } while(!int.TryParse(Console.ReadLine(),out _RightAnswerId) || (_RightAnswerId>Answers.Length || _RightAnswerId<=0));
            RightAnswerId = _RightAnswerId;
            Header = $"True Or False Question {Mark} Marks";
            Console.Clear();
        }
    }
}
