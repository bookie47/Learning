using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace โจทย์ปัญหา_หาผลรวมค่าเฉลี่ย
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, avg = 0;

            for(int count = 1; count<=5;count++)
            {
                int number;
                Console.Write("Input = ");
                int.TryParse(Console.ReadLine(), out number);
                sum += number;
            }
            Console.WriteLine("Summation = {0}", sum);
            avg = sum / 5;
            
            Console.WriteLine("Average = {0}",avg);

            Console.ReadKey();


        }
    }
}
