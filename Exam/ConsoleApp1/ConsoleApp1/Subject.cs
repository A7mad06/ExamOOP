using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Exam;

namespace ConsoleApp1
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam.Exam Exam { get; set; }
        public void CreateExam()
        {
            int Choice;
            do
            {
                Console.WriteLine("Enter the type of the exam (1 for practical | 2 for final)");
            } while (!int.TryParse(Console.ReadLine(), out Choice) || (Choice!=1 && Choice !=2));
            if (Choice == 1)
            {
                Exam = new PracticalExam();
                Exam.AddExam();
            }
            else
            {
                Exam = new FinalExam();
                Exam.AddExam();
            }
        }
    }
}