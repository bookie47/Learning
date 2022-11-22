using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace หาผลรวมไม่จำจัดจำนวน
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0, avg = 0;
             while(true)
             {
                int number;
                Console.Write("Input NUmber = ");
                int.TryParse(Console.ReadLine(), out number);
                if (number <= 0)break;
                count++;
                sum += number;
             }
            Console.WriteLine("Summation ={0} ",sum);
            avg = sum / count; ;
            Console.WriteLine("Averagr = {0}",avg);
            Console.ReadKey();

            
        }
    }
}
