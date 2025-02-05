using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.ExamClasses
{
    internal class FinalExam : Exam
    {
        public FinalExam(int duration, int count) : base(duration, count) { }

        public override void DisplayExam()
        {
            Console.WriteLine("\nFinal Exam:");
            foreach (var question in QuestionBank)
            {
                question.Display();
            }
        }
    }
}
