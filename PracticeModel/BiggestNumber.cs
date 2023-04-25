using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModel
{
    class BiggestNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int c = Convert.ToInt32(Console.ReadLine());
           
            if( a>b && a>c )
            {
                Console.WriteLine( a+ " is bigger");

            }
            if(b>a && b>c)
            {
                Console.WriteLine(b+  " is bigger");
            }
            if(c>a && c>b)
            {
                Console.WriteLine(c+ " is bigger");
            }
           
      
            
        }
        

        
    }
}
