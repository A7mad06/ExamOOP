using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions
{
    abstract class Question
    {
        public int Mark { get; set; }
        public string? Header { get; set; }
        public string? Body { get; set; }
        public Answer[]? Answers { get; set; }
        public int RightAnswerId { get; set; }
        public int UserAnswerId { get; set; }

        public void AddQuestion()
        {
            Console.WriteLine("Please Enter the question body:");
            Body=Console.ReadLine();
            int mark;
            do
            {
                Console.WriteLine("Please Enter the question Mark: ");
            }
            while (!int.TryParse(Console.ReadLine(),out mark));
            Mark = mark;
        }
    }
}
