using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.ExamClasses
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int duration, int count) : base(duration, count) { }

        public override void DisplayExam()
        {
            Console.WriteLine("\n🛠 Practical Exam:");
            foreach (var question in QuestionBank)
            {
                question.Display();
                Console.WriteLine($"Correct Answer: {question.CorrectAnswer.Text}");
            }
        }
    }
}
