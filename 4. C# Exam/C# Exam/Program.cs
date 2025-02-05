using C__Exam.ExamClasses;

namespace C__Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Answer[] options = {
            new Answer(1, "Python"),
            new Answer(2, "C#"),
            new Answer(3, "Java")
             };

            Subject subject = new Subject(101,"Software Engineering");
            MultipleChoiceQuestion q1 = new MultipleChoiceQuestion("Programming", "What is used in .NET?", 5, options, options[1]);
            TrueFalseQuestion q2 = new TrueFalseQuestion("OOP", "C# supports multiple inheritance?", 5, new Answer(2, "False"));

            FinalExam finalExam = new FinalExam(90, 2);
            finalExam.QuestionBank.Add(q1);
            finalExam.QuestionBank.Add(q2);





            subject.AssignExam(finalExam);
            subject.ShowExamDetails();
            
        }

    }
}

