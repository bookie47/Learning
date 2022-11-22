using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Program
{
    static void Main(string[] args)
    {
        int number;

        int.TryParse(System.Console.ReadLine(), out number);

        for (int i = 1; i <= number; i++)
        {
            System.Console.WriteLine("A");
        }
        System.Console.ReadKey();

    }

