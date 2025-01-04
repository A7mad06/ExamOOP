using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions
{
    internal class MCQQuestion:Question
    {
        public void AddMCQQuestion()
        {
            AddQuestion();
            int _NumberOfChoices;
            do
            {
                Console.WriteLine("Please enter the number of choices: ");
            } while (!int.TryParse(Console.ReadLine(),out _NumberOfChoices));
            Answers = new Answer[_NumberOfChoices];
            for(int i = 0; i < _NumberOfChoices; i++)
            {
                Console.WriteLine($"Please enter the choice number {i+1}: ");
                Answers[i] = new Answer(i+1,Console.ReadLine());
            }
            int _RightAnswerId;
            do
            {
                Console.WriteLine("Please enter the right answer id: ");
            } while (!int.TryParse(Console.ReadLine(),out _RightAnswerId) || (_RightAnswerId>Answers.Length || _RightAnswerId<=0));
            RightAnswerId = _RightAnswerId;
            Header = $"MCQ Question {Mark} Marks";
            Console.Clear();
        }
    }
}
