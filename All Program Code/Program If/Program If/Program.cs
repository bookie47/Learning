using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 80;

            if (score>=80)
            {
                //คำสั่งต่างๆ
                Console.WriteLine("Grade 3.5");

            }

            string name = "Saranyapong";

            if (name == "Saranyapong") 
                {
                //คำสั่งต่างๆ
                Console.WriteLine("Hello Saranyapong");


            }
            Console.WriteLine("End Program");
            Console.ReadKey();
        }
    }
}
