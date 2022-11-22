using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int choice;
            int result;
            System.Console.Write("Input Number1 = ");
            int.TryParse(Console.ReadLine(), out number1);

            System.Console.Write("Input Number2 = ");
            int.TryParse(Console.ReadLine(), out number2);

            System.Console.Write("Inptu Choice(1(+),2(-),3(*),4(/) = ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine("{0}", result);
                    break;

                case 2:
                    result = number1 - number2;
                    Console.WriteLine("{0}", result);
                    break;

                case 3:
                    result = number1 * number2;
                    Console.WriteLine("{0}", result);
                    break;

                case 4:
                    result = number1 / number2;
                    Console.WriteLine("{0}", result);
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.ReadKey();


        }
    }
}
