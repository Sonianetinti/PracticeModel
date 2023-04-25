using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModel
{
    class ReverseOfName
    {
        public static void Main(string[] args)
        {
            //reverse of a string
            string name;


            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();
            char[] strarray = name.ToCharArray();
            Array.Reverse(strarray);
            string name1 = new string(strarray);
            Console.WriteLine($"String reverse : {name1}");


            //reverse of a number
            Console.WriteLine("-------------------");
            Console.WriteLine("reverse of a number");
            int rem, sum = 0;
            Console.WriteLine("enter number");
            int i = Convert.ToInt32(Console.ReadLine());
            while (i>0)
            {
                rem = i % 10;
                sum = sum * 10 + rem;
                i = i / 10;
            }
            Console.WriteLine(sum);



        }
        
            
    }
}
