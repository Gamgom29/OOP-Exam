using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class FinalExam : BaseExam
    {
        public FinalExam(int Time, int NumberOfQuestions) : base(Time, NumberOfQuestions)
        {

        }
        public override void CreateQuestions()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int choice;
                do
                {
                    Console.WriteLine($"Enter Type Of Question Number({i + 1})  (1 for MCQ || 2 For True/False): ");
                } while (!int.TryParse(Console.ReadLine(), out  choice) || (choice!= 1 && choice !=2));
                
                if (choice == 1 || choice == 2)
                {
                    Console.WriteLine("Enter The Question Body :");
                    string? QuestionBody = Console.ReadLine();
                    int Mark;
                    do
                    {
                        Console.Write("Enter Question Mark : ");
                    } while (!int.TryParse(Console.ReadLine(), out Mark));

                    if (Questions is not null)
                    {
                        if (choice == 1)
                            Questions[i] = new McqQuestion("Choose One Answer", QuestionBody, Mark);
                        else
                            Questions[i] = new TrueFalseQuestion("True | False Question", QuestionBody, Mark);

                        Questions[i].SetAnswers();
                    }
                    Console.Clear();
                }
                else
                    Console.WriteLine("Invalid Question Type");
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
                    Console.WriteLine($"{Questions[i].HeadOfTheQuestion} \t Marks({Questions[i].Mark})");
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
            Console.WriteLine("============================ Final Exam ==========================");
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Q{i + 1} ) {Questions?[i].BodyOfTheQuestion} :  {Questions?[i].RightAnswer}");
            }
            Console.WriteLine($"You Degree : {UserMarks} / {TotalMarks}");
        }

    }
}
