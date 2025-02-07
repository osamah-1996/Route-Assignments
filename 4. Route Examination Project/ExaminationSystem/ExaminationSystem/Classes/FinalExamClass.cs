using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Enums;

namespace ExaminationSystem.Classes
{
    internal class FinalExamClass : ExamsClass
    {
        public FinalExamClass(int timeOfExam, int numberOfQuestions, QuestionsClass[] questions) : 
            base(timeOfExam, numberOfQuestions, questions)
        {
        }

        

        public override void ShowExam()
        {
            Console.WriteLine($"{new string('_', 120)}");
            Console.WriteLine($"{new string('*', 52)} PLease take Note, Your Exam Just Started {new string('*', 52)}");
            Console.WriteLine($"{new string('_', 120)}"); 
           if (Questions is not null) {
                for(int i = 0; i < Questions.Length; i++)
                {
                    QuestionsClass question = Questions[i];
                    string markText = question.Marks > 1 ? "Marks" : "Mark";
                    Console.WriteLine($"{question.Header}  |  {question.Marks} {markText}");
                    Console.WriteLine(question.Body);

                    if(question is TrueAndFalseQuestions)
                    {
                        Console.WriteLine("1]: True");
                        Console.WriteLine("2]: False");
                    }
                    else if (question is MCQQuestion MCQQ)
                    {
                        foreach (var answers in MCQQ.AnswerList!)
                        {
                            Console.Write($"{answers.AnswerId}. {answers.AnswerText} {new string(' ', 10)}");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"{new string('_', 120)}");
                    bool isValidAnswer;
                    int answer;
                    do
                    {
                        Console.Write("Enter Your Answer: ");
                        isValidAnswer = int.TryParse(Console.ReadLine(), out answer);
                    } while (!isValidAnswer);

                    StudentsAnswer[i] = answer;
                    Console.WriteLine($"{new string('_', 120)}");
                }
                Console.Clear();
                ExamResult();
            }
        }
    }
}
