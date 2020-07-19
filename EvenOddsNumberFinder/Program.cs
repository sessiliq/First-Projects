using System;

namespace EvenOddsNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }



        // чете се число от конзолата
        // ако числото е четно
        // пишем Even
        // иначе
        // пишем Odd
    }
}
