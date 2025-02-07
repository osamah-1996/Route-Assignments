using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal abstract class QuestionsClass
    {

        #region Properities for the exam  
        public string? Header { get; set; }         
        public string? Body { get; set; }           
        public int Marks { get; set; }          
        public AnswersClass[]? AnswerList { get; set; }  
        public int RightAnswers { get; set; }      
        #endregion

         #region Constructors for the exam class 
        public QuestionsClass(string? header, string? body, int marks, int NumberOfAnswers)
        {
            this.Header = header;
            this.Body = body;
            this.Marks = marks;
            this.AnswerList = new AnswersClass[NumberOfAnswers];
        }
        #endregion

        #region Abstraction Format
        public abstract void QuestionInformations();
        public abstract bool CkeckUserAnswer(int StudentAnswer);   
        #endregion
    }
}
