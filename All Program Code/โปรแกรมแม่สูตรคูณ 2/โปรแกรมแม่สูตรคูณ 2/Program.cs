using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace โปรแกรมแม่สูตรคูณ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number;

            Console.Write("Input Number = ");
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 1; i <=12 ; i++) 
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            }
            Console.ReadKey();
        } 

    }
}
