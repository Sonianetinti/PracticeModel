using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModel
{
    class EvenOdd
    {
        public static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Enter the number");
            i = Convert.ToInt32(Console.ReadLine());
            j = i % 2;
            if (j== 0)
                Console.WriteLine("Number is even");
            else
                Console.WriteLine("Number is odd");

        }
    }
}
