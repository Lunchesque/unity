using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {

            bool circle = true;

            int first = int.Parse(Console.ReadLine());
            char operand = Console.ReadLine()[0];
            int second = int.Parse(Console.ReadLine());

            while (circle)
            {

                Console.WriteLine("Enter");

                if (operand == '+')
                {
                    Console.WriteLine("result is " + (first + second));
                }
                else if (operand == '-')
                {
                    Console.WriteLine("result is " + (first - second));
                }
                else if (operand == '*')
                {
                    Console.WriteLine("result is " + (first * second));
                }
                else if (operand == '/')
                {
                    Console.WriteLine("result is " + (first / second));
                }
                else if (operand == '%')
                {
                    Console.WriteLine("result is " + (first % second));
                }
            }
        Console.ReadKey();
        }
    }
}
