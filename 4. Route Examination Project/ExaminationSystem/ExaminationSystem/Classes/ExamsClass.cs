using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal abstract class ExamsClass     
    {
        #region Exams Class Properities
        public int TimeOfExam { get; set; }          
        public int NumberOfQuestions { get; set; }
        public QuestionsClass[]? Questions { get; set; }
        public int[] StudentsAnswer { get; set; }

        #endregion

        #region Exams Class Constructor
        public ExamsClass(int timeOfExam, int numberOfQuestions , QuestionsClass[] questions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            StudentsAnswer = new int[numberOfQuestions];
            Questions = questions;
        }

        #endregion


        #region Global Varibles
        int totalScore = 0;
        int maxScore = 0;
        #endregion
        public abstract void ShowExam();

         public void ExamResult()
        {
            Console.WriteLine(new string('_', 120));
            Console.WriteLine($"{new string('*', 50)}  Exam Results  {new string('*', 50)}");
            Console.WriteLine(new string('_', 120));

            int totalScore = 0;
            int maxScore = 0;

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.Write($"Q{i + 1}: {Questions![i].Body} -> ");

                if (Questions[i].RightAnswers == StudentsAnswer[i])
                {
                    Console.WriteLine("Correct :)");
                    totalScore += (int)Questions[i].Marks;
                }
                else
                {
                    Console.WriteLine("Incorrect ):");
                }

                maxScore += (int)Questions[i].Marks;
            }

            Console.WriteLine($"Your Total Score: {totalScore} / {maxScore}");
            Console.WriteLine($"Your Score Percentage: {((double)totalScore / maxScore) * 100:0.00}%");

        }
    }
}
