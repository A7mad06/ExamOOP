using ConsoleApp1.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exam
{
    internal class PracticalExam : Exam
    {
        public MCQQuestion[]? MCQQuestions { get; set; }
        public override void AddExam()
        {
            Add();
            MCQQuestions = new MCQQuestion[NumberOfQuestions];
            for(int i = 0; i < MCQQuestions.Length; i++)
            {
                Console.WriteLine("MCQ Question : ");
                MCQQuestions[i] = new MCQQuestion();
                MCQQuestions[i].AddMCQQuestion();
                Console.Clear();
            }
            char ans;
            do
            {
                Console.WriteLine("Do you Want to Start the Exam? (y/n)");
            } while (!char.TryParse(Console.ReadLine(), out ans) || (ans != 'y' && ans != 'n'));
            Console.Clear();
            if (ans == 'y')
            {
                ShowExam();
            }
        }

        public override void ShowExam()
        {
            for(int i = 0; i < (MCQQuestions?.Length ?? 0); i++)
            {
                Console.WriteLine(MCQQuestions?[i].Header);
                Console.WriteLine(MCQQuestions?[i].Body);
                for(int j = 0; j < (MCQQuestions?[i].Answers?.Length ?? 0); j++)
                {
                    Console.WriteLine($"{MCQQuestions?[i].Answers?[j].AnswerId}-{MCQQuestions?[i].Answers?[j].AnswerText}");
                }
                int Id;
                do
                {
                    Console.WriteLine("Please enter your answer Id: ");
                } while (!int.TryParse(Console.ReadLine(),out Id));
                MCQQuestions[i].UserAnswerId = Id;
                if (MCQQuestions[i].UserAnswerId == MCQQuestions?[i].RightAnswerId)
                {
                    GotMark += MCQQuestions?[i].Mark;
                }
            }
            ShowResult();
        }

        public override void ShowResult()
        {
            for (int i = 0; i < (MCQQuestions?.Length ?? 0); i++)
            {
                Console.WriteLine($"Question {i + 1} : {MCQQuestions?[i].Body}");
                Console.WriteLine($"Right Answer => {MCQQuestions?[i].Answers?[(MCQQuestions[i].RightAnswerId)-1].AnswerText}");
            }
            Console.WriteLine($"Time = {Time}");
            Console.WriteLine("Thank You");
        }
    }
}
