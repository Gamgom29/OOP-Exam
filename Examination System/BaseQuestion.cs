using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    abstract class BaseQuestion
    {
        public string? HeadOfTheQuestion { get; set; }
        public string? BodyOfTheQuestion { get; set; }
        public int Mark { get; set; }
        public Answer[]? Answers { get; set; }
        public Answer? RightAnswer { get; set; }

        public BaseQuestion(string? HeadOfTheQuestion , string? BodyOfTheQuestion , int Mark)
        {
            this.Mark = Mark;
            this.BodyOfTheQuestion = BodyOfTheQuestion;
            this.HeadOfTheQuestion = HeadOfTheQuestion;
        }
        public BaseQuestion()
        {
            
        }
        public void ShowAnswers()
        {
            for (int i = 0; i < Answers?.Length; i++)
            {
                Console.Write($"{i + 1}. {Answers[i].AnswerText}\t ");
            }
            Console.WriteLine();
        }
        public abstract void SetAnswers();
    }
}
