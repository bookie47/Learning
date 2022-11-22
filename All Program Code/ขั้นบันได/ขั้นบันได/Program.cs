using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ขั้นบันได
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int len = 1, count, spc;
            int.TryParse(Console.ReadLine(), out count);
            spc = count - 1;

            for (int i = 1; i <= count; i++)
            {
                for (int r = 1; r <= spc; r++)
                {
                    System.Console.Write(" ");
                }
                for (int s = 1; s <= len; s++)
                {
                    System.Console.Write("*");
                }
                spc--;
                len = len + 1;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
