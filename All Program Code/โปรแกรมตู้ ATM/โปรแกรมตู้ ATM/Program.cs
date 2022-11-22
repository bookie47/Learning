using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace โปรแกรมตู้_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            do
            {
                Console.Write("Input Money =");
                int.TryParse(Console.ReadLine(), out money);
            } while ((money%100 !=0) || (money>20000)); //เช็คจำนวนเงินเป็นหลักหน่วยหรือหลักสิบ
            Console.WriteLine("Money = {0}",money);

            Console.WriteLine("1000 Bath = {0}",money/1000); //1
            money %= 1000; //1800 / 1000 =>800
            Console.WriteLine("500 Bath = {0}",money/500); //1
            money %= 500; //800 / 500 => 300
            Console.WriteLine("100 Bath = {0}", money / 100); // 3

            Console.ReadKey();
        }
    }
}
