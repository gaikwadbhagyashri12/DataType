using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class MinMax
    {
        public static void Main()
        {
            int[] arr = { 50, 30, 80, 10, 40 };
            
            int min =arr [0];
            int max =arr[0];
            
            for(int i=0;i<arr.Length-1;i++)
            {
                if(arr[i]<min)
                {
                    min=arr[i];       
                }
                if(arr[i]>max)
                {
                    max=arr[i];
                    
                }
            }
            Console.WriteLine("Minimum No:"+min);
            Console.WriteLine("Maximum No:"+max);
        }
    }
}
