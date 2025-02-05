using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.ExamClasses
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void AssignExam(Exam exam)
        {
            Exam = exam;
        }

        public void ShowExamDetails()
        {
            Console.WriteLine($"\n Subject: {SubjectName}");
            Exam.DisplayExam();
        }
    }

}
