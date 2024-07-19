using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    abstract class BaseExam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public BaseQuestion[] Questions { get; set; }

        public BaseExam(int Time , int NumberOfQuestions)
        {
            this.Time = Time;
            this.NumberOfQuestions = NumberOfQuestions;
            Questions = new BaseQuestion[NumberOfQuestions];
            
        }
        public abstract void CreateQuestions();
        public abstract void ShowExam();
       

    }
}
