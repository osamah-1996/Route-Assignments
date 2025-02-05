using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.ExamClasses
{
    internal class MultipleChoiceQuestion : Question
    {
        public MultipleChoiceQuestion(string title, string desc, int score, Answer[] options, Answer correct)
            : base(title, desc, score, options, correct) { }

        public override void Display()
        {
            Console.WriteLine($"[MCQ] {Title}: {Description} ({Score} points)");
            foreach (var ans in Options)
            {
                Console.WriteLine($"- {ans.Id}: {ans.Text}");
            }
        }
    }
}
