using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //รูปแบบคำสั่ง 2 เงื่อนไข
            /*
            string name = "Phum";
            
            if (name == "Book")
            {
                // คำสั่งต่างๆ
                Console.WriteLine("Hello Admin");
            }
            else
            {
                //คำสั่งเมื่อเงื่อไขด้านบนเป็นเท็จ
                Console.WriteLine("Hello User,{0}", name);
            }

            Console.WriteLine("End Program");
            Console.ReadKey();
            */


            /*

            int age = 14;
            
            if (age>=15)
            {
                Console.WriteLine("I'm Teen");
                

            }
            else
            {
                Console.WriteLine("I'm Children");
            }

            Console.WriteLine("End Program");
            */




            //Event Number =>คู่
            //Odd Number => คี่


            
            int number;
            Console.Write("Input Number = ");
            int.TryParse(Console.ReadLine(), out number);

            if (number % 2 == 0)
            {
                //หารลงตัว = เลขคู่
                Console.WriteLine("{0} = Event Number", number);

            }
            else
            {
                //หารไม่ลงตัว เลขคี่
                Console.WriteLine("{0} = Odd Number", number);
            }
            Console.WriteLine("End Program");
            Console.ReadKey(); 
            
        }
    }
}
