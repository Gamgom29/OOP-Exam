using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class PracticalExam : BaseExam
    {
        public PracticalExam(int Time, int NumberOfQuestions) : base(Time, NumberOfQuestions)
        {

        }

        public override void CreateQuestions()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Question Number ({i+1})");
                Console.WriteLine("Enter The Question Body :");
                string? QuestionBody = Console.ReadLine();
                int Mark;
                do
                {
                    Console.Write("Enter Question Mark : ");
                } while (!int.TryParse(Console.ReadLine(), out Mark));

                if (Questions is not null)
                {

                    Questions[i] = new McqQuestion("Choose One Answer", QuestionBody, Mark);
                    Questions[i].SetAnswers();
                }
                Console.Clear();
            }

        }
        public override void ShowExam()
        {
            Console.Clear();
            int TotalMarks = 0;
            int UserMarks = 0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                if (Questions?[i] is not null)
                {
                    Console.WriteLine(Questions[i]);
                    Questions[i].ShowAnswers();
                    Console.WriteLine("--------------------------------------");
                    int.TryParse(Console.ReadLine(), out int choice);
                    if (Questions[i].Answers[choice - 1].Equals(Questions[i].RightAnswer))
                        UserMarks += Questions[i].Mark;

                    TotalMarks += Questions[i].Mark;
                    Console.WriteLine("=======================================");
                }
            }
            Console.Clear();
            Console.WriteLine("================ Questions Right Answers ================");
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Q{i + 1} ) {Questions?[i].RightAnswer}");
            }
        }

    }
}
