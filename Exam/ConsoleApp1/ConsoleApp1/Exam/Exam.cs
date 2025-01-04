using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exam
{
    abstract class Exam
    {
        public TimeSpan Time { get; set; }
        public Stopwatch? TakenTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public int? FullMark { get; set; }
        public int? GotMark { get; set; }
        public abstract void AddExam();
        public abstract void ShowExam();
        public abstract void ShowResult();
        public void Add()
        {
            int _Time;
            do
            {
                Console.WriteLine("Please Enter the time of the exam from (30 to 180 min)");
            } while ((!(int.TryParse(Console.ReadLine(), out _Time) )|| _Time < 30 || _Time > 180));
            Time = TimeSpan.FromMinutes(_Time);
            int _NumbersOfQuestions;
            do
            {
                Console.WriteLine("Please Enter the number of questions: ");
            } while (!(int.TryParse(Console.ReadLine(), out _NumbersOfQuestions)));
            NumberOfQuestions = _NumbersOfQuestions;
            Console.Clear();
        }
    }
}
