using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class SubjectsClass 
    {

        #region Subject Class Properaties
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public ExamsClass? Exam { get; set; }
        #endregion

        #region Subject Class Constractour
        public SubjectsClass(int subjectId, string? subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        } 
        #endregion

        public void CreateExam()
        {
            #region Global Varibles
            bool IsTypesOfExams;
            int ExamTypes;
            bool IsExamTime;
            int ExamTimeTaken;
            bool IsNumberOfQuestions;
            int NumberOfQuestions;
            bool IsQType;
            int Qtype;
            bool IsMark;
            int rightAnswer;
            bool CorrectAnswer;
            #endregion

            #region Exam Create Welcoming Message
            Console.WriteLine(new string('_', 120));
            Console.WriteLine(new string('*', 45) + "  Exam Typing Instructions  " + new string('*', 46));
            Console.WriteLine(new string('_', 120));
            Console.WriteLine("Dear Examiner, Please take note of the following instructions:");
            Console.WriteLine(" - The Final Exam includes the following:");
            Console.WriteLine("   1): Multiple Choice Questions (MCQ)");
            Console.WriteLine("   2): True/False Questions");
            Console.WriteLine();
            Console.WriteLine(" - The Practical Exam includes the following:");
            Console.WriteLine("   1): Multiple Choice Questions (MCQ)");
            Console.WriteLine(new string('_', 120));
            Console.WriteLine("Please select the type of exam you want to create based on the Follwing:");
            Console.WriteLine(" 1]: Practical Exam");
            Console.WriteLine(" 2]: Final Exam");
            Console.WriteLine();
            #endregion

            #region Type of Exam Selection
            do
            {
                Console.Write("What Type of Exam Would you Like to Cretae (1 or 2): ");
                IsTypesOfExams = int.TryParse(Console.ReadLine(), out ExamTypes);
            } while (!IsTypesOfExams || (ExamTypes != 1 && ExamTypes != 2));
            #endregion



            #region Durations of the Exam
            do
            {
                Console.Write("Please enter the exam duration (in minutes): ");
                IsExamTime = int.TryParse(Console.ReadLine(), out ExamTimeTaken);

                if (!IsExamTime)
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (!IsExamTime);
            #endregion




            #region Number of Questions to be Typed
            do
            {
                Console.Write("Please enter the number of questions to create: ");
                IsNumberOfQuestions = int.TryParse(Console.ReadLine(), out NumberOfQuestions);

                if (!IsNumberOfQuestions || NumberOfQuestions <= 0)
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (!IsNumberOfQuestions || NumberOfQuestions <= 0); 
            Console.Clear();
            #endregion



            #region Select Types of Question
            Console.WriteLine($"{new string('_', 120)}");
            Console.WriteLine($"{new string('*', 120)}");
            QuestionsClass[] questions = new QuestionsClass[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                do
                {
                    Console.WriteLine("Please choose the type of question based on the following options:");
                    Console.WriteLine("1] True/False Question");
                    Console.WriteLine("2] MCQ Question");
                    Console.Write("Type of Question (1 or 2): ");

                    IsQType = int.TryParse(Console.ReadLine(), out Qtype);

                    if (!IsQType || (Qtype != 1 && Qtype != 2))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                } while (!IsQType || (Qtype != 1 && Qtype != 2)); 
                #endregion


                Console.WriteLine();


                #region True False Question
                 if (Qtype == 1)
                {
                    int Mark;
                    Console.WriteLine("True or False Questions");
                    Console.WriteLine($"{new string('_', 30)}");

                    string? body;
                    do
                    {
                       Console.WriteLine($"Please enter the body of Question {i + 1}: ");
                        body = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(body));
                    do
                    {
                        Console.Write($"Please enter the marks for Question {i + 1}: ");
                        IsMark = int.TryParse(Console.ReadLine(), out Mark);
                        if (!IsMark)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    } while (!IsMark);

                    do
                    {
                        Console.WriteLine($"Please enter the correct answer for Question {i + 1}:");
                        Console.WriteLine("1]: True");
                        Console.WriteLine("2]: False");
                        bool isParsed = int.TryParse(Console.ReadLine(), out rightAnswer);
                        CorrectAnswer = (rightAnswer == 1);
                        if (rightAnswer != 1 && rightAnswer != 2)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    } while (rightAnswer != 1 && rightAnswer != 2);
                    questions[i] = new TrueAndFalseQuestions("True or False Questions", body, Mark, CorrectAnswer);
                    Console.Clear();
                }
                #endregion



            #region Multple Chooice Question(MCQ)
                else if (Qtype == 2)
                {
                    Console.WriteLine(" Choose Only One Answer or Each Question ");
                    Console.WriteLine($"{new string('_', 40)}");
                    string? body;
                    do
                    {
                        Console.WriteLine($"Please Enter Body Of Question {i + 1} : ");
                        body = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(body));
                    bool IsMarkedParsed;
                    int Mark;
                    do
                    {
                        Console.Write($"Please Enter the Marks for Question {i + 1} : ");
                        IsMarkedParsed = int.TryParse(Console.ReadLine(), out Mark);
                    } while (!IsMarkedParsed || Mark < 0);
                    MCQQuestion MCQQuestions = new MCQQuestion("MCQ Question", body, Mark, 3);
                    Console.WriteLine("The Choices of the Question are : ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Please Enter Choice Number {j + 1} : ");
                        string? AnswerText;
                        do
                        {
                            AnswerText = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(AnswerText));

                        MCQQuestions.AddAnswer(j, j + 1, AnswerText);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Please Specify The Correct Choice Enter the Choice Number  : ");
                    int RightAnswer;
                    bool isCorrect;
                    do
                    {
                        isCorrect = int.TryParse(Console.ReadLine(), out RightAnswer);
                    } while (!isCorrect || RightAnswer < 1 || RightAnswer > 3);

                    questions[i] = MCQQuestions;

                }
            }
            #endregion


            #region Exam Succesfull or Failr Message
            if (ExamTypes == 1)
            {
                Exam = new PracticalExams(ExamTimeTaken, NumberOfQuestions, questions);
                Console.WriteLine("Practical Exam created successfully!");
            }
            else if (ExamTypes == 2)
            {
                Exam = new FinalExamClass(ExamTimeTaken, NumberOfQuestions, questions);
                Console.WriteLine("Final Exam created successfully!");
            }
            else
            {
                Console.WriteLine("Invalid exam type selected. Please try again.");
            }
            Console.Clear(); 
            #endregion

        }

    }
}
