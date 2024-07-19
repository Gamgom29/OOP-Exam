using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class Answer : ICloneable
    {
        private static int _AutoId = 1;
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }

        public Answer( string AnswerText)
        {
            this.AnswerId = _AutoId++;
            this.AnswerText = AnswerText;

        }
        public Answer(int id , string? AnswerText)
        {
            this.AnswerId= id;
            this.AnswerText = AnswerText;
        }

        public object Clone()
        {
            return new Answer(this.AnswerId, this.AnswerText);
        }

        public override bool Equals(object? obj)
        {
            Answer? answer =  (Answer?) obj;
            return ((answer?.AnswerText == this.AnswerText) && (answer?.AnswerId == this.AnswerId));
        }
        public override string ToString()
        {
            return $"{this.AnswerText}";
        }
    }
}
