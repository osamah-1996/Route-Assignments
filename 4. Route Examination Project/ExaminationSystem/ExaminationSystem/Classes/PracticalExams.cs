using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class PracticalExams : ExamsClass
    {
        public PracticalExams(int timeOfExam, int numberOfQuestions, QuestionsClass[] questions) : base(timeOfExam, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine($"{new string('_', 120)}");
            Console.WriteLine($"{new string('*', 52)} Practical Exam {new string('*', 52)}");
            Console.WriteLine($"{new string('_', 120)}");

            for (int i = 0; i < Questions!.Length; i++)
            {
                QuestionsClass question = Questions[i];

                Console.WriteLine($"{question.Header}({question.Marks} Marks)");
                Console.WriteLine(question.Body);

                if (question is TrueAndFalseQuestions)
                {
                    Console.WriteLine(" 1]: True");
                    Console.WriteLine(" 2]: False");
                }
                else if (question is MCQQuestion mcq)
                {
                    foreach (var answers in mcq.AnswerList!)
                    {
                        Console.WriteLine($"{answers.AnswerId}. {answers.AnswerText}");
                    }
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
