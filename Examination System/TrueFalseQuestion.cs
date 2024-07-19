using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class TrueFalseQuestion : BaseQuestion
    {
        public TrueFalseQuestion(string? Head, string? Body, int Mark) : base(Head, Body, Mark)
        {
            Answers = new Answer[]
            {
                new Answer("True"),
                new Answer("False")
            };

        }
        public override void SetAnswers()
        {
            Console.WriteLine("Enter The Right Answer For The Question (1 For True  2 For False)");
            int.TryParse(Console.ReadLine(), out int right);

            if(right <= 2)
            {
                RightAnswer = (Answer?) Answers?[right - 1].Clone();
            }
            else
            {
                Console.WriteLine("Invalid Answer");
            }
        }
        public override string ToString()
        {
            return $"{this.BodyOfTheQuestion}  ";
        }

        
    }
}
