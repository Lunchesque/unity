using System;

namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            bool next = true;
            while (next)
            {

                Console.WriteLine("Enter expression:");

                string expression = Console.ReadLine();
                string[] parts = expression.Split(' ');
                int first_operand = int.Parse(parts[0]);
                int second_operand = int.Parse(parts[2]);
                string action = parts[1];

                if (action == "+")
                {
                    Console.WriteLine(first_operand + second_operand);
                }
                else if (action == "-")
                {
                    Console.WriteLine(first_operand - second_operand);
                }
                else if (action == "*")
                {
                    Console.WriteLine(first_operand * second_operand);
                }
                else if (action == "/")
                {
                    Console.WriteLine(first_operand / second_operand);
                }
                else if (action == "%")
                {
                    Console.WriteLine(first_operand % second_operand);
                }
                Console.WriteLine("Wanna next calculation?(y/n):");
                char n = Console.ReadLine()[0];
                if (n == 'n')
                {
                    next = false;
                }
                else if(n == 'y')
                {
                    next = true;
                }
                Console.Clear();
            }
        }
    }
}