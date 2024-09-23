using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Break
    {
        public static void Main()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("enter any number");
                int n = Convert.ToInt32(Console.ReadLine());

                
                {
                    if (n < 0)
                    {
                        break;
                    }
                    sum=sum+n;
                }
            }
            Console.WriteLine("Sum:"+sum);
        }
    }
}
