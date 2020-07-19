using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', cols));
            for (int i = 0; i < rows - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', cols - 2) + "*");
            }

            {
                Console.WriteLine(new string('*', cols));

            }
        }
    }
}
