using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            if (symbol == '+')
            {
                Console.WriteLine(num1 + num2);
            }
            else if (symbol == '-')
            {
                Console.WriteLine(num1 - num2);
            }
            else if (symbol == '*')
            {
                Console.WriteLine(num1 * num2);
            }
            else if (symbol == '/')
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("wrong symbol");
            }
        }
    }
}
