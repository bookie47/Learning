using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = 10;
            do
            {
               Console.WriteLine("Hello World = {0}",count) ;
                count++;
            } while (count<=3);

            Console.WriteLine("End Program");
            Console.ReadKey();


        }
    }
}
