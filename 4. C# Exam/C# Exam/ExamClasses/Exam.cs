using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.ExamClasses
{
    internal abstract class Exam
    {
        public int Duration { get; set; }
        public int QuestionCount { get; set; }
        public List<Question> QuestionBank { get; set; }

        public Exam(int duration, int count)
        {
            Duration = duration;
            QuestionCount = count;
            QuestionBank = new List<Question>();
        }

        public abstract void DisplayExam();
    }
}
