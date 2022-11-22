using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace หาตัวเลขต่ำสุด_สูงสุด
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue, maxNumber = 0;
            while (true)
            {
                int number;
                Console.Write("Input Number = ");
                int.TryParse(Console.ReadLine(), out number);
                if (number <= 0) break;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine("Max = {0}", maxNumber);
            Console.WriteLine("Min = {0}", minNumber);
            Console.ReadKey();
        }
    }
}
