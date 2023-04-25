using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModel
{
    class SumOfNos
    {
        public static void Main(string[] args)
        {
            int[] n = new int[9];
            int sum = 0;

            Console.WriteLine("enter the numbers:");
           
            for(int i=0;i<n.Length;i++)
            {
                
                n[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(n[i]);
                sum = sum + n[i];
            }
            Console.WriteLine(sum);
        }                                                                                                                                                                                                                                                                                                         
    }
}
