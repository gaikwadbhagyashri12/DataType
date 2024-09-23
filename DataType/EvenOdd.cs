using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class EvenOdd
    {
        public static void Main()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            even_odd(num);
        }
        public static void even_odd(int[]num)
        {
            for (int i = 0; i<num.Length; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("Even No:"+i);
                }
                else
                {
                    Console.WriteLine("Odd No:"+i);
                }
            }

        }        
    }
}
