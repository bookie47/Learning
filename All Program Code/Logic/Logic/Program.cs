using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gender = "male";
            int height = 180;

            /*
            //AND และ
            if (gender == "male" && height >= 160)
            {
                Console.WriteLine("Pass");
            }

            else
            {
                Console.WriteLine("Not Pass");
            }*/


            /*
            //OR หรือ
            if (gender == "male" || height >=160)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not Pass");
            }
            */


            int age = 80; //ตรงกันข้าม

            if (!(age >= 80)) //true => false 
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("F");
            }
            
            

            

            


            Console.ReadKey();
        }
    }
}
