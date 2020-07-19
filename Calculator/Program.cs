using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == '+')
            {
                Console.WriteLine(number1 + number2);
            }
            else if (symbol == '-')
            {
                Console.WriteLine(number1 - number2);
            }
            else if (symbol == '*')
            {
                Console.WriteLine(number1 * number2);
            }
            else if (symbol == '/')
            {
                Console.WriteLine(number1 % number2);    
            }
            else
            {
                Console.WriteLine("Invalid symbol!");
            }
        }

        // Четат се 2 числа от конзолата и един символ
        // върху прочетените числа се иавършва математическата операция описана със символа
        // четене
        // 1 | 3 | 4
        // 2 | 2 | 5
        // + | - | 6
        //-----------
        // писане
        // 3 | 1 | Invalid symbol!
    }
}
