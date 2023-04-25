using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModel
{
    class Equal_Or_Not
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a==b)
            {
                Console.WriteLine("numbers are equal");
            }
            else
            {
                Console.WriteLine("number is not equal");
            }


        }

    }
}
