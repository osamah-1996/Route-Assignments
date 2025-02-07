using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class MCQQuestion : QuestionsClass
    {
        #region MCQ Question Constructor
        public MCQQuestion(string? header, string? body, int marks, int NumberOfAnswers) :
           base(header, body, marks, NumberOfAnswers)
        {
            AnswerList = new AnswersClass[NumberOfAnswers];
        }

        #endregion

        #region MCQ Question Methods
        public void AddAnswer(int id, int answerId, string answerText)
        {
            if (id >= 0 && id < AnswerList!.Length)
            {
                AnswerList![id] = new AnswersClass(answerId, answerText);
            }else
            {
                Console.WriteLine($"Error: Index {id} is out of bounds.");
            }
        }

         public override void QuestionInformations()
        {
            if (AnswerList is not null && AnswerList.Length > 0)
            {
                for (int i = 0; i < AnswerList!.Length; i++)
                {
                    Console.WriteLine($"{AnswerList[i].AnswerId}   ||   {AnswerList[i].AnswerText}");
                }
            }
        }

         public override bool CkeckUserAnswer(int StudentAnswer)
        {
            return StudentAnswer == RightAnswers;
        }

         

        #endregion
    }
}
