using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.ExamClasses
{
    internal class Answer
    {
        #region This is the Answer Class Properaties
        public int Id { get; set; }
        public string Text { get; set; }

        #endregion
        #region This is the Answer Class Constrcutor
        public Answer(int id, string text)
        {
            Id = id;
            Text = text;
        }
        #endregion


        
    }
}
