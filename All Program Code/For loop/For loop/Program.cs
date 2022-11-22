using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int number;
            Console.Write("Input Number = ");
            int.TryParse(Console.ReadLine(), out number);
            for (int count=1;count<=12 ;count++ )
            {
                //คำสั่งที่ต้องการให้การทำซ้ำ
                Console.WriteLine("{0} x {1} = {2}", number, count, number * count);
            }*/


            int number;
            Console.Write("Input Product =");
            int.TryParse(Console.ReadLine(), out number);
            for (int count = 1; count <= number; count++)
            {
                Console.WriteLine("Product {0}", count);
            }


            Console.ReadKey();

        }
    }
}
