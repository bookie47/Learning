using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_else_many_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Input
            int score;
            Console.Write("Input Score:");
            int.TryParse(Console.ReadLine(), out score);

            //Process % Output
            if (score >= 80)
            {
                Console.WriteLine("Grade A");
            } else if (score >= 70)
            {
                Console.WriteLine("Grade B");
            } else if (score >= 60)
            {
                Console.WriteLine("Greade C");
            } else if (score >= 50)
            {
                Console.WriteLine("Grade D");
            } else
            {
                Console.WriteLine("Grade F");
            }
            Console.ReadKey();



        
            
             



            



            

        }
    }
}
