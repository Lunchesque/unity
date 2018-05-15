using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first_variable = 2;
            //int second_variable;
            //second_variable = 10;
            //Console.WriteLine("hello world");
            //int a = 10;
            //int s = -2;
            //a = s + a * 2;

            //int b = 5;
            //int c = 2;
            //b = b / c;

            //int a = 7;
            //int b = 4;
            //bool r = a == b || a <= 10;     
            /*  || = logic or
                ! = отрициние
                && = logic and
             */

            /*
            if (a != b)
            {
                Console.WriteLine("R is true");
            }
            else if (10 < 11)
            {
                Console.WriteLine("10 < 11");
            }
            else
            {
                Console.WriteLine("All worng");
            }
            */

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //char c = Console.ReadLine()[0];


            
            //if (c == '+')
            //{
            //    Console.WriteLine(a + b);
            //}
            //else if (c == '-')
            //{
            //    Console.WriteLine(a - b);
            //}
            //else if (c == '*')
            //{
            //    Console.WriteLine(a * b);
            //}
            //else if (c == '/')
            //{
            //    Console.WriteLine(a / b);
            //}
            //else if (c == '%')
            //{
            //    Console.WriteLine(a % b);
            //}

            int a = 2;
            int b = 1;

            for (int i=0 ; i<10 ;i++ )
            {
                Console.WriteLine(b *= a);
            }


            Console.ReadKey();

            
        }
    }
}
