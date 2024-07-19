using System.Diagnostics;

namespace Examination_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new(10, "C#");
            sub.CreateExam();
            Console.Clear();

            Console.WriteLine("Do You Want To Start Exam y | n");

            char.TryParse(Console.ReadLine(), out char Choice);
            if (Choice == 'y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                sub?.Exam?.ShowExam();
                Console.WriteLine($" Time : {stopwatch.Elapsed}");
            }
        }
    }
}
