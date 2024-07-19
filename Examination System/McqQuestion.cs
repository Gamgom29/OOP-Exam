using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class McqQuestion : BaseQuestion
    {
        public McqQuestion(string? Head , string? Body , int Mark):base(Head , Body , Mark)
        {
            this.Answers = new Answer[3];
        }
        public McqQuestion()
        {
            
        }
        public override void SetAnswers()
        {
            for (int i = 0; i < Answers?.Length; i++)
            {
                Console.Write($"Enter The Choice Number ({i+1}) : ");
                string? Ans = Console.ReadLine();
                Answers[i] = new Answer(Ans ?? "");
            }
            int right;
            do
            {
                Console.Write("Specify The Right Answer For The Question ( 1 , 2 , 3 ) : ");
            } while (!int.TryParse(Console.ReadLine(), out right) || (right!= 1 && right != 2 && right != 3));
            
            RightAnswer = (Answer?) Answers?[right - 1].Clone();
        }
        
        public override string ToString()
        {
            return $"{this.BodyOfTheQuestion}  ";
        }

       
    }
}
