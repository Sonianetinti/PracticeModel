using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModel
{
    class ComparingStrings
    {
        public static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("enter the first string");
            a = Console.ReadLine();
            Console.WriteLine("enter the second string");
            b = Console.ReadLine();
            if (String.Equals(a, b))
                Console.WriteLine(a +   "and" + b + "is same");
            else
                Console.WriteLine(a +    "and " + b + "is not same");



        }
    }
}
