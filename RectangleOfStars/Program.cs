using System;

namespace RectangleOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', number));
            for (int i = 0; i < number - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', number - 2) + "*");
            }
            Console.WriteLine(new string('*', number));
        }
    }
}
