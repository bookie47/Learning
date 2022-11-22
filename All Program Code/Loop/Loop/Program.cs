using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While

            int count = 1;
            int number;
            Console.Write("Input Number = ");
            int.TryParse(Console.ReadLine(), out number);

            while (count<= 12)
            {
                //คำสั่งที่ต้องการให้ทำซ้ำ
                //2 x 1 = 2
                Console.WriteLine("{0} x {1} = {2}",number ,count,number*count); 
                count++;
            }

            Console.ReadKey();
            




        }
    }
}
