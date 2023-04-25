using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModel
{
    class SumOfDigits
    {
       public static void Main(string[] args)
        {
            //sum of digits using for loop 
             int n,sum = 0;
            Console.WriteLine("enter the number:");
            int i= Convert.ToInt32(Console.ReadLine());
            for(i=0;i!=0;i=i/10)
            {
                n = i % 10;
                sum = sum + n;

            }
            Console.WriteLine(sum);
        }

    }
}
