using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 50;
            string result;
            result = (score >= 50) ? "Pass" : "Not Pass";

            Console.WriteLine("Status = {0}", result);
            Console.ReadKey();
        }
    }
}
