using System;

namespace PracticeModel
{
    class PositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
                Console.WriteLine(i + "is equal to 0");
            else if (i < 0)
                Console.WriteLine(i + "is negative");
            else
                Console.WriteLine(i + "is positive");
        }
    }
}
