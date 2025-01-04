using ConsoleApp1.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Exam
{
    internal class FinalExam : Exam
    {
        public MCQQuestion[] MCQQuestions { get; set; }
        public int NumberOfMCQQuestions { get; set; }
        public TrueOrFalseQuestion[] TrueOrFalseQuestions { get; set; }
        public int NumberOfTrueOrFalseQuestions { get; set; }

        public override void AddExam()
        {
            Add();
            FullMark = 0;
            GotMark = 0;
            NumberOfMCQQuestions = 0;
            NumberOfTrueOrFalseQuestions = 0;
            MCQQuestions = new MCQQuestion[NumberOfQuestions];
            TrueOrFalseQuestions = new TrueOrFalseQuestion[NumberOfQuestions];
            for (int j = 0; j < NumberOfQuestions; j++)
            {
                int Choice;
                do
                {
                    Console.WriteLine("Enter the type of the Question: (1 for MCQ | 2 for True | False)");
                } while (!int.TryParse(Console.ReadLine(), out Choice) || (Choice != 1 && Choice != 2));
                Console.Clear();
                if (Choice == 1)
                {
                    Console.WriteLine("MCQ Question: ");
                    MCQQuestions[NumberOfMCQQuestions] = new MCQQuestion();
                    MCQQuestions[NumberOfMCQQuestions].AddMCQQuestion();
                    FullMark += MCQQuestions[NumberOfMCQQuestions].Mark;
                    NumberOfMCQQuestions++;
                }
                else
                {
                    Console.WriteLine("True Or False Question: ");
                    TrueOrFalseQuestions[NumberOfTrueOrFalseQuestions] = new TrueOrFalseQuestion();
                    TrueOrFalseQuestions[NumberOfTrueOrFalseQuestions].AddTrueOrFalseQuestion();
                    FullMark += TrueOrFalseQuestions[NumberOfTrueOrFalseQuestions].Mark;
                    NumberOfTrueOrFalseQuestions++;
                }
            }
            char ans;
            do
            {
                Console.WriteLine("Do you Want to Start the Exam? (y/n)");
            } while (!char.TryParse(Console.ReadLine(),out ans) || (ans!='y' && ans!='n'));
            if (ans == 'y')
            {
                ShowExam();
            }
        }

        public override void ShowExam()
        {
            TakenTime = new System.Diagnostics.Stopwatch();
            TakenTime.Start();
            for (int i = 0; i < NumberOfMCQQuestions; i++)
            {
                Console.WriteLine(MCQQuestions?[i].Header);
                Console.WriteLine(MCQQuestions?[i].Body);
                for (int j = 0; j < (MCQQuestions?[i].Answers?.Length ?? 0); j++)
                {
                    Console.WriteLine($"{MCQQuestions[i].Answers[j].AnswerId}-{MCQQuestions[i].Answers[j].AnswerText}");
                }
                int Id;
                do
                {
                    Console.WriteLine("Please enter your answer Id: ");
                } while (!int.TryParse(Console.ReadLine(), out Id));
                MCQQuestions[i].UserAnswerId = Id;
                if (MCQQuestions[i].UserAnswerId == MCQQuestions?[i].RightAnswerId)
                {
                    GotMark += MCQQuestions?[i].Mark;
                }
            }
            for (int i = 0; i < NumberOfTrueOrFalseQuestions; i++)
            {
                Console.WriteLine(TrueOrFalseQuestions?[i].Header);
                Console.WriteLine(TrueOrFalseQuestions?[i].Body);
                for (int j = 0; j < (TrueOrFalseQuestions?[i].Answers?.Length ?? 0); j++)
                {
                    Console.WriteLine($"{TrueOrFalseQuestions[i].Answers[j].AnswerId}-{TrueOrFalseQuestions[i].Answers[j].AnswerText}");
                }
                int Id;
                do
                {
                    Console.WriteLine("Please enter your answer Id: ");
                } while (!int.TryParse(Console.ReadLine(), out Id));
                TrueOrFalseQuestions[i].UserAnswerId = Id;
                if (TrueOrFalseQuestions[i].UserAnswerId == TrueOrFalseQuestions?[i].RightAnswerId)
                {
                    GotMark += TrueOrFalseQuestions?[i].Mark;
                }
            }
            TakenTime.Stop();
            ShowResult();
        }

        public override void ShowResult()
        {
            for(int i = 0; i < NumberOfMCQQuestions; i++)
            {
                Console.WriteLine($"Question {i+1} : {MCQQuestions[i].Body}");
                Console.WriteLine($"Your Answer => {MCQQuestions[i].Answers?[(MCQQuestions[i].UserAnswerId)-1].AnswerText}");
                Console.WriteLine($"Right Answer => {MCQQuestions[i].Answers?[(MCQQuestions[i].RightAnswerId)-1].AnswerText}");
            }
            for(int i = 0; i < NumberOfTrueOrFalseQuestions; i++)
            {
                Console.WriteLine($"Question {i+1} : {TrueOrFalseQuestions?[i].Body}");
                Console.WriteLine($"Your Answer => {TrueOrFalseQuestions?[i].Answers?[(TrueOrFalseQuestions[i].UserAnswerId)-1].AnswerText}");
                Console.WriteLine($"Right Answer => {TrueOrFalseQuestions?[i].Answers?[(TrueOrFalseQuestions[i].RightAnswerId)-1].AnswerText}");
            }
            Console.WriteLine($"Your Grade is {GotMark} out of {FullMark}");
            Console.WriteLine($"Time = {TakenTime}");
            Console.WriteLine("Thank You");
        }
    }
}
