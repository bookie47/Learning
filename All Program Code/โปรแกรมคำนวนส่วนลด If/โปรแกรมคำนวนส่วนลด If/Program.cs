using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace โปรแกรมคำนวนส่วนลด_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int money = 28000;

            if (money >= 15000)
            {
                Console.WriteLine("Sell");
                if (money >= 15000 && money <=19999)
                {
                    Console.WriteLine("Sale 10%");
                }
                else if (money >= 20000 && money <= 29999) 
                {
                    Console.WriteLine("Sale 20 %");
                }
                else if (money >= 30000)
                {
                    Console.WriteLine("Sale 30%");
                }

            }
            else
            {
                Console.WriteLine("Not sell");
            }

            Console.ReadKey();
        }
    }
}
