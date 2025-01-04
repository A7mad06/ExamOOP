using ConsoleApp1.Exam;
using ConsoleApp1.Questions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject su = new Subject();
            su.CreateExam();
        }
    }
}
