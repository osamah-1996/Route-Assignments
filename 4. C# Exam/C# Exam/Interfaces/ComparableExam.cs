using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Exam.ExamClasses;

namespace C__Exam.Interfaces
{
    internal class ComparableExam : Exam, IComparable<ComparableExam>
    {
        public ComparableExam(int duration, int count) : base(duration, count) { }

        public override void DisplayExam()
        {
            Console.WriteLine("\n Comparable Exam:");
            foreach (var question in QuestionBank)
            {
                question.Display();
            }
        }

        public int CompareTo(ComparableExam other)
        {
            return this.QuestionCount.CompareTo(other.QuestionCount);
        }
    }

}
