using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModel
{
    class Fibnocci
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            Console.WriteLine("enter number");
            int temp = Int32.Parse(Console.ReadLine());
            Console.WriteLine(a + " " + b);
            for(int i=2;i<temp;i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
