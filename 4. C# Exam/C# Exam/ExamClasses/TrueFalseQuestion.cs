using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.ExamClasses
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string title, string desc, int score, Answer correct)
            : base(title, desc, score, new Answer[] { new Answer(1, "True"), new Answer(2, "False") }, correct) { }

        public override void Display()
        {
            Console.WriteLine($"[True/False] {Title}: {Description} ({Score} points)");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }
    }
}
