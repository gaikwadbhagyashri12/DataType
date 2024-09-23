using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class SumOfArray
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int sum = 0;
            
            foreach(int i in arr)
            {
                Console.WriteLine(" "+i);
                sum=sum+i;
                Console.WriteLine("Sum="+sum);
            }
            int avg = sum/arr.Length;
            Console.WriteLine("Average is: "+avg);
        }
    }
}
