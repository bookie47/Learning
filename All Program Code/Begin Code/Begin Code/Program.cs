using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //31/07/65
            /*
            //การสร้างคำสั่งแสดงแบบคำ เริ่มบรรทัดใหม่
            Console.WriteLine("Program PMR Student");
            Console.WriteLine(12);
            Console.WriteLine(188);
            Console.WriteLine(18 * 2);
            Console.WriteLine("Helo");
            Console.WriteLine("Saranyapong");
            */

            /*
            //เช็คความถูกต้อง
            Console.WriteLine(900 == 100);
            Console.WriteLine(15 == 15);
            */

            /*
            //การส้รางคำสั่งแบบปีกกา บอกลำดับ
            Console.WriteLine("HEllo FirstName = Saranyapong LastName = Phoksawas");//แสดงประวัติส่วนตัว
            Console.WriteLine("Hello FirstName = {0} LastName = {1} Age = {2} Address = {3} ", "Saranyapong", "Phoksawas", 18 ,"Chainat");
            Console.WriteLine("{0} + {1} = {2}", 100, 200, 300);
            Console.WriteLine("{0} + {0} = {1}", 100, 200, 300);
            Console.WriteLine("{1} - {0} = {0}", 100, 200, 300);//แสดงข้อความออกทางจอภาพ
                                                                //Console.WriteLine("{0} + {0} = {1}", 100, 200, 300);
            */


            /*
            //การสร้างค่านิยามตัวแปร int
            int x = 10;
            int y = 20;
            int mm = 180;
            int z = x + y + mm;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            int q = 100, w = 600, e;
            e = q + w;

            Console.WriteLine(q);
            Console.WriteLine(w);
            Console.WriteLine(e);


            int xx = 50, yy = 40;
            Console.WriteLine(xx);
            Console.WriteLine(yy);

            xx = 5000;
            yy = 10000;
            Console.WriteLine(xx);
            Console.WriteLine(yy);
            */

            /*
            //การสร้างค่านิยามตัวแปร float เป็นการเก็บค่าแบบมีทศนิยม
            float a = 12.12f; 

            Console.WriteLine(a);


            float b = 15f;

            Console.WriteLine(b);
            */

            /*
            //การสร้างตัวแปร double
            double c;
            c = 500;
            double d = 600;
            double Answer0;
            Answer0 = c + d;

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(Answer0);

            */

            /*
            //การสร้างตัวแปร boolean ค่าทางตรรกศาสตร์
            bool status0 = false;
            bool status1 = true;
            */

            /*
            //การสร้าง char & string
            char AL = 'A';
            string name = "Saranyapong";

            Console.WriteLine(AL);
            Console.WriteLine(name);

            */

            /*
            //Constant การนิยามค่าคงที่
            const int SIZE = 70;
            Console.WriteLine(SIZE);
            */

            /*
            //Format String
            int number = 1234567;
            Console.WriteLine("Number = {0}", number);
            Console.WriteLine("Number = {0:E}", number);
            Console.WriteLine("Number = {0:F}", number);
            Console.WriteLine("Number = {0:F5}", number);
            Console.WriteLine("Number = {0:G}", number);
            Console.WriteLine("Number = {0:N}", number);
            Console.WriteLine("Number = {0:P}", number);
            Console.WriteLine("Number = {0:X}", number);

            int num = 10;
            Console.WriteLine("Number = {0:X}", num);

            */

            //รับข้อมูลแป้นพิมพ์

            Console.Write("Username = ");
             string User = Console.ReadLine();
             Console.WriteLine("Username = {0}", User);


             Console.Write("Password = ");
             string Pass = Console.ReadLine();
             Console.WriteLine("Password = {0}", Pass);

             Console.Write("Address = ");
             string Ad = Console.ReadLine();
             Console.WriteLine("Address = {0}", Ad);
            

            /*
            //ตัวดำเนินการทางคณิตศาสตร์
            int ant = 10;
            int bird = 5;
            
            Console.WriteLine("Result = {0}", ant+bird);
            Console.WriteLine("Result = {0}", ant * bird);
            Console.WriteLine("Result = {0}", ant/bird);
            Console.WriteLine("Result = {0}", ant % bird);


            double ka = 18.6;
            double fa = 19.7;
            double ha = ka + fa;
            Console.WriteLine("Result = {0}",ha);
            */

            /*
            //ฟังก์ชั่นทางคณิตศาสตร์
            float fucn = 16.87f;
            Console.WriteLine("Abs = {0}", Math.Abs(fucn));
            Console.WriteLine("Ceiling = {0}", Math.Ceiling(fucn));
            Console.WriteLine("Floor = {0}", Math.Floor(fucn));
            Console.WriteLine("Round = {0}", Math.Round(fucn));
            Console.WriteLine("Pow = {0:F2}", Math.Pow(2, 5));
            Console.WriteLine("Square Root = {0}", Math.Sqrt(900));
            Console.WriteLine("PI = {0:F3}", Math.PI);
            Console.WriteLine("E = {0:F3}", Math.E);
            */
            

            /*
            //ตัวดำเนินการเปรียบเทียบ
            int number11 = 50, number12 = 100;
            

            Console.WriteLine(number11 == number12);
            Console.WriteLine(number11 != number12);
            Console.WriteLine(number11 > number12);
            Console.WriteLine(number11 < number12);
            Console.WriteLine(number11 >= number12);
            Console.WriteLine(number11 <= number12);
            */

            /*
            //ตัวดำเนินการเพิ่มค่า - ลดค่า
            int Book = 5, Book2 = 10;
            /*
            //เพิ่มค่า
            Console.WriteLine("Book = {0}", Book); //5
            Console.WriteLine("postfix = {0}", ++Book); //6
            Console.WriteLine("last Book = {0}", Book); //6

            Book = 5;
            Console.WriteLine("Book = {0}", Book); //5
            Console.WriteLine("prefix = {0}", Book++); //5
            Console.WriteLine("last Book = {0}", Book); //6

            */
            /*
            //ลดค่า
            Console.WriteLine("Book2 = {0}", Book2); //10
            Console.WriteLine("prefix = {0}", --Book2); //9
            Console.WriteLine("Last b = {0}", Book2);

            Book2 = 10;
            Console.WriteLine("Book2 = {0}", Book2);
            Console.WriteLine("postfix = {0}", Book2--);
            Console.WriteLine("last Book2 = {0}", Book2);
            */

            //Compound Assignment

            //1.+= Ex = x+=y ,x=x+y
           /*
            int x = 100,y = 15;

            //Console.WriteLine(x += y); // x =x+y
            //Console.WriteLine(x -= y);
            //Console.WriteLine(x *= y);
            //Console.WriteLine(x /= y);
            Console.WriteLine(x %= y);           


            //ลำดับความสำคัญของตัวดำเนินการ
           */

            //การแปลงข้อมูล






            //ตัวอ่าน ตัวRun Code
            Console.ReadKey();


            



        }
    }

        }

 
