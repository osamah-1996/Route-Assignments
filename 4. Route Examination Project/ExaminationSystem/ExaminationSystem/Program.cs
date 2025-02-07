using System.Diagnostics;
using ExaminationSystem.Classes;
using ExaminationSystem.Enums;

namespace ExaminationSystem
{
    internal class Program
    {  //This Function for Displaying the Header of the main board welcome Message!!
        public static void MainBoardWelcomeMessage(string title)
        {
            int width = 120;  
            string border = new string('_', width);
            string starBorder = new string('*', width);
            Console.WriteLine(border);
            Console.WriteLine(border);
            int padding = (width - title.Length) / 2;
            Console.WriteLine(new string('*', padding) + title + new string('*', padding));
            Console.WriteLine(border);
        }




        static void Main(string[] args)
        {

            #region Calling the Main Boar dWelcome Message
            MainBoardWelcomeMessage("\"Welcome To Examination Boarding System\"");
            #endregion


            #region Global Varibale Declearation
            int width = 120;
            bool isParced;
            int SubjectId; 
            string? SubjectName;
            string? StartExam;
            #endregion


            #region Taken the Subject Id
            do
            {
                Console.Write("Please enter a valid Subject ID (Numeric Only): ");
                isParced = int.TryParse(Console.ReadLine(), out SubjectId);

                if (!isParced)
                {
                   Console.WriteLine();
                    Console.WriteLine("Invalid input Subject ID!");
                }
            } while (!isParced);
            //Console.WriteLine();
            #endregion


            #region Taken the Subject Name
            do
            {
                Console.Write("Please enter a valid Subject Name (cannot be empty): ");
                SubjectName = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(SubjectName))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input! Subject Name cannot be empty.");
                }
            } while (string.IsNullOrWhiteSpace(SubjectName));

            Console.Clear();
            #endregion
            #region Create Exam Instance Based on Subject
            SubjectsClass sub01 = new SubjectsClass(SubjectId, SubjectName);
            Console.WriteLine();
            string border = new string('_', width);
            sub01.CreateExam();
            #endregion





            #region Start the Exam
            do
            {
                Console.Write("Do you want to start the exam? (Y/N): ");
                StartExam = Console.ReadLine()?.Trim().ToUpper() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(StartExam) || (StartExam != "Y" && StartExam != "N"))
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (StartExam != "Y" && StartExam != "N");

            if (StartExam == "Y" || StartExam =="y")
            {
                Console.Clear();
                if (sub01.Exam != null)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    sub01.Exam.ShowExam();
                    sw.Stop();
                    Console.WriteLine($"Exam completed in {sw.Elapsed.Minutes} min {sw.Elapsed.Seconds} sec");
                }
                else
                {
                    Console.WriteLine("Error: No exam found! Please create an exam first.");
                }
            }
            else
            {
                Console.WriteLine("Exam cancelled. Exiting...");
            } 
            #endregion
        }


    }
}
