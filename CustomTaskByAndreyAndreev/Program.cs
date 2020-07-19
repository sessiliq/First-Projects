using System;

namespace CustomTaskByAndreyAndreev
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', cols));
            for (int i = 0; i < rows - 2; i++)
            {
                Console.WriteLine('*' + new string(' ', cols - 2) + '*');
            }
            Console.WriteLine(new string('*', cols));
        }

        // Uslovie: Създай програма която чете от конзолата 2 числа, и създава правоъгълник от звездички
        // 3, 4    4, 5     3, 5
        // ****    *****    *****
        // *  *    *   *    *   *
        // ****    *   *    *****
        //         *****
        //
        //
    }
}
