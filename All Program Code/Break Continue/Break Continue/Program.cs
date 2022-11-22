using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int number;
            Console.Write("Input Number =");
            int.TryParse(Console.ReadLine(), out number);

            for (int count = 1; count <= 12; count++)
            {
                if (count == 10)
                {
                    break;
                }
                Console.WriteLine("{0} x {1} = {2}", number, count, number * count);

            }
            */

            int number;
            Console.Write("Input Number =");
            int.TryParse(Console.ReadLine(), out number);

            for (int count = 1; count <= 12; count++)
            {
                if (count == 10)
                {
                    continue;
                }
                Console.WriteLine("{0} x {1} = {2}", number, count, number * count);

            }

            Console.WriteLine("End Program");
            Console.ReadKey();
        }
    }       
}    
