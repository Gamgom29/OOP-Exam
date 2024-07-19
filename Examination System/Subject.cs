using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public BaseExam? Exam { get; set; }

        public Subject(int id , string? name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            int choice;

            do
            {
                Console.Write("Enter Type Of Exam You Want To Create ( 1 For Practical 2 For Final ) : ");
            } while (!int.TryParse(Console.ReadLine(), out choice));

            int Time;

            do
            {
                Console.Write("Enter Exam Time in minutes: ");
            }
            while (!int.TryParse(Console.ReadLine(), out Time));

            int NumOfQuestions;
            do
            {
                Console.Write("Enter Number Of Questions : ");
            } while (!int.TryParse(Console.ReadLine(), out NumOfQuestions));
            
            if (choice == 1) 
            {
                Exam = new PracticalExam(Time, NumOfQuestions);
                Exam.CreateQuestions();

            }
            else if (choice == 2) 
            {
                Exam = new FinalExam(Time, NumOfQuestions);
                Exam.CreateQuestions();
            }

            else Console.WriteLine("Invalid Exam Type");
        }

    }
}
