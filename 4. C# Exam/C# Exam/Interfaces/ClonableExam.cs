using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Exam.ExamClasses;

namespace C__Exam.Interfaces
{
    internal class ClonableExam : Exam, ICloneable
    {
        public ClonableExam(int duration, int count) : base(duration, count) { }

        public override void DisplayExam()
        {
            Console.WriteLine("\n Clonable Exam:");
            foreach (var question in QuestionBank)
            {
                question.Display();
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
