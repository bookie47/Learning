using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace โปรแกรมสั่งเมนูอาหาร
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Console.WriteLine("1.Candy 2.Bread 3.Milk 4.Noodle 5.Sncak");
            Console.Write("You Choose = ");
            int.TryParse(Console.ReadLine(), out menu);

            if (menu == 1)
            {
                Console.WriteLine("Candy");
            }
            else if (menu == 2)
            {
                Console.WriteLine("Bread");
            }
            else if (menu == 3)
            {
                Console.WriteLine("Milk");
            }
            else if (menu == 4)
            {
                Console.WriteLine("Noodle");
            }
            else if (menu == 5)
            {
                Console.WriteLine("Snack");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            Console.ReadKey();
        }
    }       
}
