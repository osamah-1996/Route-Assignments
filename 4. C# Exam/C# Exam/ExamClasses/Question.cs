using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.ExamClasses
{
    internal abstract class Question
    {
        #region This is the Question class
        public string Title { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        public Answer[] Options { get; set; }
        public Answer CorrectAnswer { get; set; }
        #endregion

        #region This is the Question Class Constractour
        public Question(string title, string desc, int score, Answer[] options, Answer correct)
        {
            Title = title;
            Description = desc;
            Score = score;
            Options = options;
            CorrectAnswer = correct;
        }

        #endregion
        public abstract void Display();
    }

}
