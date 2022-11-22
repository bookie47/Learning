using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace โปรแกรมตัดเกรด
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            string grade;
            Console.Write("Input score = ");
            int.TryParse(Console.ReadLine(), out score);
            
            
            if (score >= 80 && score<=100)
            {
                grade = "A";
            }else if(score>=70 && score <= 79)
            {
                grade = "B";

            }else if(score >= 60 && score <= 69)
            {
                grade = "c";
            }else if(score >=50 && score <= 59)
            {
                grade = "D";
            }else if (score >= 0 && score < 50)
            {
                grade = "F";
            }
            else
            {
                grade = "Not Data";
            }

            Console.WriteLine("Score = {0} ,Grade = {1}", score,grade);
            Console.ReadKey();


        }
    }
}
