using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace แม่สูตรคูณ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int number;

            Console.Write("Inpunt Number =");
            int.TryParse(Console.ReadLine(), out number);

            while (count <=1000)
            {
                Console.WriteLine("{0} x {1} = {2}", number, count, number * count);
                count++;
            }

            Console.ReadKey();
        }
    }
}
